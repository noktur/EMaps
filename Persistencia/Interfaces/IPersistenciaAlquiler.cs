using EntidadesCompartidas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistencia.Interfaces
{
    public interface IPersistenciaAlquiler
    {
        void AltaAlquiler(Alquiler e);
        void BajaAlquiler(Alquiler e);
        Alquiler BuscarAlquiler(int IdAlquiler);
        List<Alquiler> ListarAlquileres();
        List<Alquiler> ListarAlquileresLugar(string NombreLugar);

    }
}
