using System;
using System.Collections.Generic;

namespace PrimerParcial
{
    internal abstract class Vuelo
    {
        public abstract int AsientosLibres(string destino);
        public abstract List<string> Descargar(string destino, int cantidad);
    }
}