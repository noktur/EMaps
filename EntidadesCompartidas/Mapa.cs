using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCompartidas
{
    [DataContract]
    public class Mapa
    {
        #region Atributos

        private int _IdMapa;
        private string _UrlImagen;
        private string _Nombre;
        private List<Area> _ListaAreas;

        #endregion
        
        #region Propiedades

        [DataMember]
        public int IdMapa
        {
            get { return _IdMapa; }
            set { _IdMapa = value; }
        }

        [DataMember]
        public string UrlImagen
        {
            get { return _UrlImagen;}
            set { _UrlImagen = value; }
        }

        [DataMember]
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        [DataMember]
        public List<Area> Areas
        {
            get { return _ListaAreas; }
            set { _ListaAreas = value; }
        }

        #endregion

        #region Constructores

        public Mapa(int pIdMapa,string pUrlImagen,string pNombre)
        {
            UrlImagen = pUrlImagen;
            Nombre = pNombre;
            IdMapa = pIdMapa;
        }
        public Mapa(int pIdMapa, string pUrlImagen, string pNombre,List<Area> pListaAreas)
        {
            UrlImagen = pUrlImagen;
            Nombre = pNombre;
            IdMapa = pIdMapa;
            Areas = pListaAreas;
        }


        public Mapa()
        {
            IdMapa = 0;
            UrlImagen = "";
            Nombre = "";
        }
        #endregion
    }
}
