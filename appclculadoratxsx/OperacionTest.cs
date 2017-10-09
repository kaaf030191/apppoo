using AppCalculadora;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace appclculadoratxsx
{
    [TestClass]
    public class OperacionTest
    {
        [TestMethod] //decoradores patrones de diseño estructurales
        public void SumarSieteYCuatroROnce()
        {
            Operacion operacion = new Operacion();

            float resultado = operacion.Sumar(7, 4);
            Assert.AreEqual(11,resultado);
        }
    }
}
