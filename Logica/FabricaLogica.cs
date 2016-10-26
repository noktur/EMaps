using Logica.ClasesTrabajo;
using Logica.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class FabricaLogica
    {
        public static ILogicaLugar getLogicaLugar()
        {
            return (LogicaLugar.GetInstancia());
        }

        public static ILogicaMapa getLogicaMapa()
        {
            return (LogicaMapa.GetInstancia());
        }
        
        public static ILogicaPunto getLogicaPunto()
        {
            return (LogicaPunto.GetInstancia());
        }

        public static ILogicaUbicacion getLogicaUbicacion()
        {
            return (LogicaUbicacion.getInstancia());
        }
        public static ILogicaUsuario getLogicaUsuario()
        {
            return (LogicaUsuario.getInstancia());
        }
        public static ILogicaEvento getLogicaEvento()
        {
            return LogicaEvento.GetInstance();
        }

    }
}
