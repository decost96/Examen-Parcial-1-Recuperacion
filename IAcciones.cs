using System.Collections.Generic;

namespace PrimerParcial
{
    internal interface IAcciones
    {
        List<string> Comprar(Vuelo vuelo, int cantidad, string destino);
    }
}