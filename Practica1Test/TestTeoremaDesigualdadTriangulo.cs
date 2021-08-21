using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica1;
using System;

namespace Practica1Test
{
    [TestClass]
    public class TestTeoremaDesigualdadTriangulo
    {
        [TestMethod]
        public void TestCase1Triangulo_3_4_5_True()
        {
            int ladoA = 3,
                ladoB = 4,
                ladoC = 5;

            var servicio = new VerificarTeoremaDesigualdadTrianguloService();
            var response = servicio.Verificar(
                ladoA,
                ladoB,
                ladoC);

            Assert.AreEqual(true, response);
        }

        [TestMethod]
        public void TestCase2Triangulo_5_12_13_True()
        {
            int ladoA = 5,
                ladoB = 12,
                ladoC = 13;

            var servicio = new VerificarTeoremaDesigualdadTrianguloService();
            var response = servicio.Verificar(
                ladoA,
                ladoB,
                ladoC);

            Assert.AreEqual(true, response);
        }

        [TestMethod]
        public void TestCase3Triangulo_5_7_13_False()
        {
            int ladoA = 5,
                ladoB = 7,
                ladoC = 13;

            var servicio = new VerificarTeoremaDesigualdadTrianguloService();
            var response = servicio.Verificar(
                ladoA,
                ladoB,
                ladoC);

            Assert.AreEqual(false, response);
        }

        [TestMethod]
        public void TestCase4Triangulo_5_9_3_False()
        {
            int ladoA = 5,
                ladoB = 9,
                ladoC = 3;

            var servicio = new VerificarTeoremaDesigualdadTrianguloService();
            var response = servicio.Verificar(
                ladoA,
                ladoB,
                ladoC);

            Assert.AreEqual(false, response);
        }
    }
}
