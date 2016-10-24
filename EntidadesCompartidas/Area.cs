﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCompartidas
{
    [DataContract]
    public class Area
    {
        #region Atributos

        private int _IdArea;
        private string _NombreArea;
        private string _Color;
        private Mapa _MapaAsociado;
        private Punto _PuntosArea;

        #endregion

        #region Propiedades

        [DataMember]
        public int IdArea
        {
            get { return _IdArea; }
            set { _IdArea = value; }
        }
        
        [DataMember]
        public string NombreArea
        {
            get { return _NombreArea; }
            set { _NombreArea = value; }
        }

        [DataMember]
        public string Color
        {
            get { return _Color; }
            set { _Color = value; }
        }

        [DataMember]
        public Punto PuntosArea
        {
            get { return _PuntosArea; }
            set { _PuntosArea = value; }
        }
        
        [DataMember]
        public Mapa MapaAsociado
        {
            get { return _MapaAsociado; }
            set { _MapaAsociado = value; }
        }

        #endregion

        
        #region Constructores
        
        public Area(int pIdArea,string pNombreArea,string pColor,Mapa pMapaAsociado,Punto pPuntosArea)
        {
            IdArea = pIdArea;
            NombreArea = pNombreArea;
            Color = pNombreArea;
            PuntosArea = pPuntosArea;
            MapaAsociado = pMapaAsociado;
        }

        public Area()
        {
            IdArea = 0;
            NombreArea = "";
            Color = "";
            PuntosArea = null;
            MapaAsociado = null;
        }

        #endregion
    }
}
