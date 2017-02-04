using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Topicos.Calculadora.Tests
{
    [TestClass]
    public class BusinessLogic
    {
        [TestMethod]
        public void SumarTodosLosElementosEnCero()
        {
            //preparacion del escenario
            List<double> miLista = new List<double> { 0, 0, 0, 0, 0, 0, 0, 0 };
            double resultadoEsperado = 0.0;

            var laAccion = new Dominio.Acciones.Sumar();
            var elResultadoObtenido = laAccion.RealizarOperacion(miLista);

            Assert.AreEqual(resultadoEsperado, elResultadoObtenido);
        }

        

    }
}
