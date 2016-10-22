using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
using Persistencia;
using Logica.Interfaces;

namespace Logica.ClasesTrabajo
{
    internal class LogicaEvento:ILogicaEvento
    {
        private static LogicaEvento _instance = null;
        private LogicaEvento() { }
        public static LogicaEvento GetInstance()
        {
            if (_instance == null)
                _instance = new LogicaEvento();

            return _instance;
        }
            
        public void CrearEvento(Evento E)
        {
            FabricaPersistencia.getPersistenciaEvento().CrearEvento(E);
        }

        public Evento BuscarEvento(int idEvento)
        {
            return FabricaPersistencia.getPersistenciaEvento().BuscarEvento(idEvento);
        }

        public List<Evento> ListarEventos()
        {
            return FabricaPersistencia.getPersistenciaEvento().ListarEventos();
        }
    }
}
