using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
 
namespace EntidadesCompartidas
{
    public class Alquiler
    {
        #region Atributos

        private int _IdAlquiler;
        private Lugar _LugarAlquiler;
        private Organizador _ClienteAlquiler;
        private DateTime _FechaAlquiler;

        #endregion

         #region Propiedades

        [DataMember]
         public int IdAlquiler
         {
             get { return _IdAlquiler;}
             set {
                    _IdAlquiler = value;
                 }
         }

        [DataMember]
         public Lugar LugarAlquiler
         {
             get { return _LugarAlquiler;}
             set { _LugarAlquiler = value; }
         }

         [DataMember]
         public Organizador ClienteAlquiler
         {
             get { return _ClienteAlquiler; }
             set { _ClienteAlquiler = value; }
         }

          [DataMember]
         public DateTime FechaAlquiler
         {
             get { return _FechaAlquiler; }
             set { _FechaAlquiler = value; }
         }
         
         #endregion

         #region Constructores
         
         public Alquiler(int pIdAlquiler,Lugar pLugarAlquiler,Organizador pUnClienteAlquiler,DateTime pFechaAlquiler)
         {
             IdAlquiler= pIdAlquiler;
             LugarAlquiler = pLugarAlquiler;
              ClienteAlquiler= pUnClienteAlquiler;
             FechaAlquiler=pFechaAlquiler;
         }

         public Alquiler()
         {
             IdAlquiler = 0;
             LugarAlquiler = null;
             FechaAlquiler = DateTime.Now;
             ClienteAlquiler = null;
         }

         #endregion

    }
}
