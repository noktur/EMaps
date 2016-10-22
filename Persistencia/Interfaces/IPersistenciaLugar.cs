using EntidadesCompartidas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Interfaces
{
    public interface IPersistenciaLugar
    {
        void AltaLugar(Lugar l);
        void ModificarLugar(Lugar l);
        Lugar BuscarLugarxId(int pIdLugar,string pNombreCiudad,string pNombrePais);
        void BajaLugar(Lugar l);
    }
}
