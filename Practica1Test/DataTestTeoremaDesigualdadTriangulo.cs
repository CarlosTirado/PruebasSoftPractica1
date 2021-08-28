using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica1;
using System;

namespace Practica1Test
{
    [TestClass]
    public class DataTestTeoremaDesigualdadTriangulo
    {
        [DataTestMethod]
        [DataRow(3, 4, 5)]
        [DataRow(5, 12, 13)]
        [DataRow(5, 13, 12)]
        [DataRow(12, 13, 5)]
        public void TestTrianguloTrue_DataRow(
            int ladoA,
            int ladoB,
            int ladoC)
        {
            var servicio = new VerificarTeoremaDesigualdadTrianguloService();
            var response = servicio.Verificar(
                ladoA,
                ladoB,
                ladoC);

            Assert.IsTrue(response);
        }

        [DataTestMethod]
        [DataRow(5, 7, 13)]
        [DataRow(5, 9, 3)]
        [DataRow(13, 7, 5)]
        [DataRow(1, 2, -1)]
        public void TestTrianguloFalse_DataRow(
            int ladoA,
            int ladoB,
            int ladoC)
        {
            var servicio = new VerificarTeoremaDesigualdadTrianguloService();
            var response = servicio.Verificar(
                ladoA,
                ladoB,
                ladoC);

            Assert.IsTrue(!response);
        }
    }
}
