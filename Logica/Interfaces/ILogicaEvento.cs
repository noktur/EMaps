using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;

namespace Logica.Interfaces
{
    public interface ILogicaEvento
    {
        void CrearEvento(Evento E);
        Evento BuscarEvento(int idEvento);
        List<Evento> ListarEventos();
    }
}
