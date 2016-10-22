using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;

namespace Persistencia.Interfaces
{
    public interface IPersistenciaEvento
    {
        void CrearEvento(Evento E);
        Evento BuscarEvento(int IdEvento);
        List<Evento> ListarEventos();
    }
}
