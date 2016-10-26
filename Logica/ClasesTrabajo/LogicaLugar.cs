using EntidadesCompartidas;
using Logica.Interfaces;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica.ClasesTrabajo
{
    internal class LogicaLugar:ILogicaLugar
    {
        #region Singleton
        private static LogicaLugar instancia = null;
        private LogicaLugar() { }
        public static LogicaLugar GetInstancia()
        {
            if (instancia == null)
                instancia = new LogicaLugar();
            return instancia;
        }
        #endregion

        #region Operaciones
        public void AltaLugar(Lugar l)
        {
            FabricaPersistencia.getPersistenciaLugar().AltaLugar(l);
        }

        public void ModificarLugar(Lugar l)
        {
            FabricaPersistencia.getPersistenciaLugar().ModificarLugar(l);
        }

        public void BajaLugar(Lugar l)
        {
            FabricaPersistencia.getPersistenciaLugar().BajaLugar(l);
        }

        public Lugar BuscarLugarxId(int IdLugar,string NombreCiudad,string NombrePais)
        {
            return FabricaPersistencia.getPersistenciaLugar().BuscarLugarxId(IdLugar,NombreCiudad,NombrePais);
        }

        #endregion
    }
}
