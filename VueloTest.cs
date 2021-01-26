using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Telerik.JustMock;
using Telerik.JustMock.Helpers;

namespace PrimerParcial
{
    [TestClass]
    public class VueloTest
    {
        [TestMethod]
        public void ComprarEntrada()
        {
            string destino = "Quito - Guayaquil";
            int cantidad = 2;
            int asientosDisponibles = 3;
            var vuelo = Mock.Create<Vuelo>();
            vuelo.Arrange(v => v.AsientosLibres(destino)).Returns(asientosDisponibles);
            vuelo.Arrange(v => v.Descargar(destino, cantidad)).Returns(new List<string>{"A1","B3","C5"});


            Persona persona = new Persona();
            persona.ComprarPasaje(vuelo, cantidad, destino);

            Assert.IsTrue(persona.CompraExitosa);
            vuelo.Arrange(v => v.AsientosLibres(destino));
            vuelo.Arrange(v => v.Descargar(destino, cantidad));

        }
    }
}
