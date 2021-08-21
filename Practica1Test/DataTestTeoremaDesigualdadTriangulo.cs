using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica1;
using System;

namespace Practica1Test
{
    [TestClass]
    public class DataTestTeoremaDesigualdadTriangulo
    {
        [DataTestMethod]
        [DataRow(3, 4, 5, true)]
        [DataRow(5, 12, 13, true)]
        [DataRow(5, 7, 13, false)]
        [DataRow(5, 9, 3, false)]
        public void Test(
            int ladoA,
            int ladoB,
            int ladoC,
            bool resultadoEsperado)
        {
            var servicio = new VerificarTeoremaDesigualdadTrianguloService();
            var response = servicio.Verificar(
                ladoA,
                ladoB,
                ladoC);

            Assert.AreEqual(response, resultadoEsperado);
        }
    }
}
