﻿using appCalculadora;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace appCalculadoraTestx
{
    [TestClass]
    public class OperacionTest
    {
        [TestMethod]
        public void SumarSieteYCuatroROnce()
        {
            Operacion operacion = new Operacion();

            float resultado = operacion.Sumar(7, 4);

            Assert.AreEqual(11, resultado);
        }
    }
}
