using System;
using System.Collections.Generic;

namespace PrimerParcial
{
    internal class Persona
    {
        List<string> pasaje;
        public bool CompraExitosa { get;  set; }
        public object Pasaje { get; set; }

        internal void ComprarPasaje(Vuelo vuelo, int cantidad, string destino)
        {
            if (vuelo.AsientosLibres(destino) >= cantidad)
            {
                pasaje = vuelo.Descargar(destino, cantidad);
            }
        }
    }
}