using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCompartidas
{
    [DataContract]
    public class Evento
    {
       #region Atributos

        private int _IdEvento;
        private string _NombreEvento;
        private string _Descripcion;
        private DateTime _FechaEvento;
        private Lugar _UnLugar;
        private Categoria _CategoriaEvento;
        private Boolean _Reservacion;
        private Organizador _OrganizadorEvento;

       #endregion

       #region Propiedades


        [DataMember]
        public int IdEvento
        {
            get { return _IdEvento; }
            set { _IdEvento = value; }
        }

        [DataMember]
        public string NombreEvento
        {
            get { return _NombreEvento;}
            set { _NombreEvento = value; }
        }

        [DataMember]
        public string Descripcion
        {
            get { return _Descripcion;}
            set { _Descripcion = value;}
        }

        [DataMember]
        public DateTime FechaEvento
        {
            get { return _FechaEvento; }
            set { _FechaEvento = value; }
        }

        [DataMember]
        public Lugar UnLugar
        {
            get { return _UnLugar; }
            set { _UnLugar = value; }
        }

        [DataMember]
        public Categoria CategoriaEvento
        {
            get { return _CategoriaEvento; }
            set { _CategoriaEvento = value; }
        }

        [DataMember]
        public Boolean Reservacion
        {
            get { return _Reservacion; }
            set { _Reservacion = value; }
        }

        public Organizador OrganizadorEvento
        {
            get { return _OrganizadorEvento; }
            set { _OrganizadorEvento = value; }
        }

       #endregion

       #region Constructores

        public Evento(int pIdEvento,string pNombreEvento,string pDescripcion,DateTime pFechaEvento,Lugar pUnLugar,Categoria pCategoria,Boolean pReservacion,Organizador pOrganizadorEvento)
        {
            IdEvento = pIdEvento;
            NombreEvento = pNombreEvento;
            Descripcion = pDescripcion;
            FechaEvento = pFechaEvento;
            UnLugar = pUnLugar;
            CategoriaEvento = pCategoria;
            Reservacion = pReservacion;
            OrganizadorEvento = pOrganizadorEvento;
        }

        public Evento()
        {
            IdEvento = 0;
            NombreEvento = "";
            Descripcion = "";
            FechaEvento = DateTime.Now;
            UnLugar = null;
           CategoriaEvento = null;
           Reservacion = false;
           OrganizadorEvento = null;
        }


       #endregion
    }
}
