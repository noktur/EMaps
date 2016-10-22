using EntidadesCompartidas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Interfaces
{
    public interface IPersistenciaCiudad
    {
        void AltaCiudad(Ciudad c);
        void ModificarCiudad(Ciudad c);
        Ciudad BuscarCiudad(String NombreCiudad, Pais UnPais);
        void BajaCiudad(Ciudad c);
        List<Ciudad> ListarCiudades();

        List<Ciudad> ListarCiudadesPais(Pais UnPais);
    }
}
