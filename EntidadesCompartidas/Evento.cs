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

        private string _NombreEvento;
        private string _Descripcion;
        private DateTime _FechaEvento;
        private Lugar _UnLugar;
        private List<Entrada> _EntradasEvento;
        private Interes _ClasificacionEvento ;

       #endregion

       #region Propiedades

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
        public List<Entrada> EntradasEvento 
        {
            get { return _EntradasEvento; }
            set { _EntradasEvento = value; }
        }

        [DataMember]
        public Interes ClasificacionEvento
        {
            get { return _ClasificacionEvento; }
            set { _ClasificacionEvento = value; }
        }


       #endregion

       #region Constructores

        public Evento(string pNombreEvento,string pDescripcion,DateTime pFechaEvento,Lugar pUnLugar,List<Entrada> pEntradas,Interes pClasificacion)
        {
            NombreEvento = pNombreEvento;
            Descripcion = pDescripcion;
            FechaEvento = pFechaEvento;
            UnLugar = pUnLugar;
            EntradasEvento = pEntradas;
            ClasificacionEvento = pClasificacion;
        }

        public Evento()
        {
            NombreEvento = "";
            Descripcion = "";
            FechaEvento = DateTime.Now;
            UnLugar = null;
            EntradasEvento = new List<Entrada>();
            ClasificacionEvento = null;
        }


       #endregion
    }
}
