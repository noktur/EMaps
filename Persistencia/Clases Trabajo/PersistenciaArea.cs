using EntidadesCompartidas;
using MySql.Data.MySqlClient;
using Persistencia.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Persistencia.Clases_Trabajo
{
    internal class PersistenciaArea:IPersistenciaArea
    {
        
          #region Singleton
        private static PersistenciaArea _instancia = null;

        private PersistenciaArea() { }

        public static PersistenciaArea GetInstancia()
        {
            if (_instancia == null)
                _instancia = new PersistenciaArea();

            return _instancia;
        }

        #endregion

        #region Operaciones

        public void AltaArea(Area a)
        {
            MySqlConnection con = new MySqlConnection(Conexion.Cnn);
            MySqlCommand cmd = new MySqlCommand("AltaArea", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("pNombre", a.NombreArea);
            cmd.Parameters.AddWithValue("pColor", a.Color);
            cmd.Parameters.AddWithValue("pIdPunto", a.PuntosArea.IdPunto);
            cmd.Parameters.AddWithValue("pIdMapa", a.MapaAsociado.IdMapa);


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

        public void ModificarArea(Area a)
        {
            MySqlConnection con = new MySqlConnection(Conexion.Cnn);
            MySqlCommand cmd = new MySqlCommand("ModificarArea", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("pIdArea", a.IdArea);
            cmd.Parameters.AddWithValue("pNombre", a.NombreArea);
            cmd.Parameters.AddWithValue("pColor", a.Color);
            cmd.Parameters.AddWithValue("pIdPunto", a.PuntosArea.IdPunto);
            cmd.Parameters.AddWithValue("pIdMapa", a.MapaAsociado.IdMapa);


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

        public Area BuscarArea(int IdArea,int IdMapa,int IdPunto)
        {
            Area UnArea = null;

            MySqlConnection con = new MySqlConnection(Conexion.Cnn);
            MySqlCommand cmd = new MySqlCommand("BuscarArea", con);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("pIdArea", IdArea);
            cmd.Parameters.AddWithValue("pIMapa", IdMapa);
            cmd.Parameters.AddWithValue("pIdPunto", IdPunto);


            try
            {
                con.Open();
                MySqlDataReader oReader = cmd.ExecuteReader();
                if (oReader.HasRows)
                {
                    oReader.Read();
                    UnArea = new Area(IdArea,(string)oReader["NombreArea"], (string)oReader["Color"],FabricaPersistencia.getPersistenciaMapa().BuscarMapa(IdMapa),FabricaPersistencia.getPersistenciaPunto().BuscarPuntoxId(IdPunto));
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
            return UnArea;
        }

        public void BajaArea(Area a)
        {
            MySqlConnection con = new MySqlConnection(Conexion.Cnn);
            MySqlCommand cmd = new MySqlCommand("EliminarArea", con);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("pIdArea", a.IdArea);


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
