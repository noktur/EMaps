using EntidadesCompartidas;
using MySql.Data.MySqlClient;
using Persistencia.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Clases_Trabajo
{
    internal class PersistenciaLugar:IPersistenciaLugar
    {
         #region Singleton
        private static PersistenciaLugar _instancia = null;

        private PersistenciaLugar() { }

        public static PersistenciaLugar GetInstancia()
        {
            if (_instancia == null)
                _instancia = new PersistenciaLugar();

            return _instancia;
        }

        #endregion
        

        #region Operaciones

        public void AltaLugar(Lugar l)
        {
            MySqlConnection con = new MySqlConnection(Conexion.Cnn);
            MySqlCommand cmd = new MySqlCommand("AltaLugar", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("pNombre", l.Nombre);
            cmd.Parameters.AddWithValue("pDireccion", l.Direccion);
            cmd.Parameters.AddWithValue("pCapacidad", l.Capacidad);
            cmd.Parameters.AddWithValue("pDescripcion", l.Descripcion);
            cmd.Parameters.AddWithValue("pNombreUbicacion", l.UbicacionLugar.Nombre);
            cmd.Parameters.AddWithValue("pIdMapa", l.MapaLugar.IdMapa);
            cmd.Parameters.AddWithValue("pCordX", l.CoordenadaX);
            cmd.Parameters.AddWithValue("pCordY", l.CoordenadaY);


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Problema con la base de datos: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void ModificarLugar(Lugar l)
        {
            MySqlConnection con = new MySqlConnection(Conexion.Cnn);
            MySqlCommand cmd = new MySqlCommand("ModificarLugar", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("pNombre", l.Nombre);
            cmd.Parameters.AddWithValue("pDireccion", l.Direccion);
            cmd.Parameters.AddWithValue("pCapacidad", l.Capacidad);
            cmd.Parameters.AddWithValue("pDescripcion", l.Descripcion);
            cmd.Parameters.AddWithValue("pNombreUbicacion", l.UbicacionLugar.Nombre);
            cmd.Parameters.AddWithValue("pIdMapa", l.MapaLugar.IdMapa);


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error con la base de datos: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public Lugar BuscarLugarxId(int IdLugar,string NombreCiudad,string NombrePais)
        {
            Lugar UnLugar = null;

            MySqlConnection con = new MySqlConnection(Conexion.Cnn);
            MySqlCommand cmd = new MySqlCommand("BuscarLugarxId", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pIdLugar", IdLugar);
            cmd.Parameters.AddWithValue("pNombreCiudad", NombreCiudad);
            cmd.Parameters.AddWithValue("pNombrePais", NombrePais);

            try
            {
                con.Open();
                MySqlDataReader oReader = cmd.ExecuteReader();
                if (oReader.HasRows)
                {
                    oReader.Read();
                    UnLugar = new Lugar(IdLugar, (string)oReader["Nombre"], (string)oReader["Direccion"], (string)oReader["Descripcion"], (int)oReader["Capacidad"], PersistenciaCiudad.GetInstancia().BuscarCiudad(NombreCiudad,PersistenciaPais.GetInstancia().BuscarPais(NombrePais)),PersistenciaMapa.GetInstancia().BuscarMapa((int)oReader["IdMapa"]),Convert.ToSingle(oReader["CordX"]),Convert.ToSingle(oReader["CordY"]));
                }
                oReader.Close();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error con la base de datos: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return UnLugar;
        }


        public void BajaLugar(Lugar l)
        {
            MySqlConnection con = new MySqlConnection(Conexion.Cnn);
            MySqlCommand cmd = new MySqlCommand("EliminarLugar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pIdLugar", l.IdLugar);


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error con la Base de Datos: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        #endregion
    }
}
