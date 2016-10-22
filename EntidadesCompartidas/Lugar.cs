using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCompartidas
{
    [DataContract]
    public class Lugar
    {
        #region Atributos

        private int _IdLugar;
        private string _Nombre;
        private string _Direccion;
        private string _Descripcion;
        private int _Capacidad;
        private Ciudad _UbicacionLugar;
        private Mapa _MapaLugar;
        private List<Servicio> _ServiciosLugar;
        private float _CoordenadaX;
        private float _CoordenadaY;

        #endregion

        #region Propiedades

        [DataMember]
        public int IdLugar
        {
            get { return _IdLugar; }
            set { _IdLugar = value; }
        }

        [DataMember]
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        [DataMember]
        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        [DataMember]
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
        
        [DataMember]
        public int Capacidad
        {
            get { return _Capacidad; }
            set { _Capacidad = value; }
        }

        [DataMember]
        public Ciudad UbicacionLugar
        {
            get { return _UbicacionLugar; }
            set { _UbicacionLugar = value; }
        }

        [DataMember]
        public Mapa MapaLugar
        {
            get { return _MapaLugar; }
            set { _MapaLugar=value; } 
        }

        [DataMember]
        public List<Servicio> ServiciosLugar
        {
            get { return _ServiciosLugar; }
            set { _ServiciosLugar = value; }
        }

        [DataMember]
        public float CoordenadaX
        {
            get { return _CoordenadaX; }
            set { _CoordenadaX = value; }
        }

        [DataMember]
        public float CoordenadaY
        {
            get { return _CoordenadaY; }
            set { _CoordenadaY = value; }
        }

        #endregion

        #region Constructores
        public Lugar(int pIdLugar,string pNombre,string pDireccion,string pDescripcion,int pCapacidad,Ciudad pUbicacionLugar,Mapa pMapaLugar,float pCoordenadaX,float pCoordenadaY)
        {
            IdLugar = pIdLugar;
            Direccion = pDireccion;
            Descripcion = pDescripcion;
            Capacidad = pCapacidad;
            UbicacionLugar = pUbicacionLugar;
            MapaLugar = pMapaLugar;
            CoordenadaX = pCoordenadaX;
            CoordenadaY = pCoordenadaY;
        }

        public Lugar()
        {
            IdLugar = 0;
            Direccion = "";
            Descripcion = "";
            Capacidad = 0;
            UbicacionLugar = null;
            MapaLugar = null;
            ServiciosLugar = new List<Servicio>();
            CoordenadaX = 0;
            CoordenadaY = 0;
        }

        #endregion
    }
}
