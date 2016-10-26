using EntidadesCompartidas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica.Interfaces
{
    public interface ILogicaLugar
    {
        void AltaLugar(Lugar l);
        void ModificarLugar(Lugar l);
        Lugar BuscarLugarxId(int IdLugar, string NombreCiudad, string NombrePais);
        void BajaLugar(Lugar l);
    }
}
