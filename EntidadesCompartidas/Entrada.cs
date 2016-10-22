using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCompartidas
{
    [DataContract]
     public class Entrada
     {
         #region Atributos

         private double _Precio;
         private string _Beneficios;
         private Cliente _UnCliente;
         
         #endregion

         #region Propiedades

        [DataMember]
         public double Precio
         {
             get { return _Precio;}
             set {
                 if (value > 0)
                    _Precio = value;
                else
                    throw new Exception("&$ El precio no puede ser negativo &$");
                 }
         }

        [DataMember]
         public string Beneficios
         {
             get { return _Beneficios;}
             set { _Beneficios = value; }
         }

         [DataMember]
         public Cliente UnCliente
         {
             get { return _UnCliente; }
             set { _UnCliente = value; }
         }
         

         #endregion

         #region Constructores
         
         public Entrada(double pPrecio,string pBeneficios,Cliente pUnCliente)
         {
             Precio = pPrecio;
             Beneficios = pBeneficios;
             UnCliente = pUnCliente;
         }

         public Entrada()
         {
             Beneficios = "";
             Precio = 1;
             UnCliente = null;
         }

         #endregion
     }
}
