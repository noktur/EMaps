using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistencia.Interfaces;
using EntidadesCompartidas;
using MySql.Data.MySqlClient;
using System.Data;

namespace Persistencia.Clases_Trabajo
{
    internal class PersistenciaEvento:IPersistenciaEvento
    {
        private static PersistenciaEvento _instancia = null;
        private PersistenciaEvento() { }
        public static PersistenciaEvento GetInstance() {
            if (_instancia == null)
                _instancia = new PersistenciaEvento();
            return _instancia;
        }

        public void CrearEvento(Evento E) {
            MySqlConnection cnn = new MySqlConnection(Conexion.Cnn);
            string oComando = "CrearEvento";
            MySqlCommand cmd = new MySqlCommand(oComando, cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            MySqlParameter oNombre = new MySqlParameter("pNombre", E.NombreEvento);
            MySqlParameter oDescripcion = new MySqlParameter("pDescripcion", E.Descripcion);
            MySqlParameter oFecha = new MySqlParameter("pFecha", E.FechaEvento);
            MySqlParameter oIdLugar = new MySqlParameter("pIdLugar",E.UnLugar.IdLugar);
            //MySqlParameter oOrganizador = new MySqlParameter("pCiOrganizador",);
            MySqlParameter oInteres = new MySqlParameter("pInteres", E.ClasificacionEvento.NombreInteres);

            cmd.Parameters.Add(oNombre);
            cmd.Parameters.Add(oDescripcion);
            cmd.Parameters.Add(oFecha);
            cmd.Parameters.Add(oIdLugar);
            cmd.Parameters.Add(oInteres);


            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }

        public Evento BuscarEvento(int IdEvento)
        {
            Evento UnEvento = null;

            MySqlConnection cnn = new MySqlConnection(Conexion.Cnn);
            string oComando = "BuscarEvento";
            MySqlCommand cmd = new MySqlCommand(oComando, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataReader lector;

            MySqlParameter oIdEvento = new MySqlParameter("pIdEvento",IdEvento);

            cmd.Parameters.Add(oIdEvento);

            try
            {
                cnn.Open();
                lector = cmd.ExecuteReader();

                if (lector.Read())
                {
                   string Nombre = (string)lector["Nombre"];
                   string Descripcion = (string)lector["Descripcion"];
                   DateTime Fecha = (DateTime)lector["Fecha"];
                   Lugar LugarEvento = PersistenciaLugar.GetInstancia().BuscarLugarxId((int)lector["IdLugar"],"","");
                   //Interes InteresEvento = PersistenciaInteres.GetInstancia().BuscarInteres((string)lector["Interes"]);
                   List < Entrada > Entradas = new List<Entrada>();

                   UnEvento = new Evento(Nombre,Descripcion,Fecha,LugarEvento,Entradas,new Interes());
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                cnn.Close();
            }

            return UnEvento;
        }

        public List<Evento> ListarEventos() {
            
            Evento UnEvento;
            List<Evento> lista = null;

            MySqlConnection cnn = new MySqlConnection(Conexion.Cnn);
            string oComando = "ListarEventos";
            MySqlCommand cmd = new MySqlCommand(oComando, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataReader lector;

            try
            {
                cnn.Open();
                lector = cmd.ExecuteReader();
                if (lector.HasRows)
                {
                    lista = new List<Evento>();

                    while (lector.Read())
                    {
                        string Nombre = (string)lector["Nombre"];
                        string Descripcion = (string)lector["Descripcion"];
                        DateTime Fecha = (DateTime)lector["Fecha"];
                        Lugar LugarEvento = PersistenciaLugar.GetInstancia().BuscarLugarxId((int)lector["IdLugar"], "", "");
                        //Interes InteresEvento = PersistenciaInteres.GetInstancia().BuscarInteres((string)lector["Interes"]);
                        List<Entrada> Entradas = new List<Entrada>();

                        UnEvento = new Evento(Nombre, Descripcion, Fecha, LugarEvento, Entradas, new Interes());

                        lista.Add(UnEvento);

                    }
                }
            }

            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
    }
}
