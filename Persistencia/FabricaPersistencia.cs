﻿using Persistencia.Clases_Trabajo;
using Persistencia.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class FabricaPersistencia
    {
        public static IPersistenciaAdmin getPersistenciaAdmin()
        {
            return (PersistenciaAdmin.GetInstancia());
        }
        public static IPersistenciaArea getPersistenciaArea()
        {
            return (PersistenciaArea.GetInstancia());
        }

        public static IPersistenciaCiudad getPersistenciaCiudad()
        {
            return (PersistenciaCiudad.GetInstancia());
        }

        public static IPersistenciaCliente getPersistenciaCliente()
        {
            return (PersistenciaCliente.GetInstancia());
        }

        public static IPersistenciaDueño getPersistenciaDueño()
        {
            return (PersistenciaDueño.GetInstancia());
        }

         public static IPersistenciaLugar getPersistenciaLugar()
        {
            return (PersistenciaLugar.GetInstancia());
        }

         public static IPersistenciaMapa getPersistenciaMapa()
        {
            return (PersistenciaMapa.GetInstancia());
        }

         public static IPersistenciaOrganizador getPersistenciaOrganizador()
         {
             return (PersistenciaOrganizador.GetInstancia());
         }

        public static IPersistenciaPais getPersistenciaPais()
        {
            return (PersistenciaPais.GetInstancia());
        }
       
        public static IPersistenciaPunto getPersistenciaPunto()
        {
            return (PersistenciaPunto.GetInstancia());
        }
    }
}