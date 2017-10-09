using AppCalculadora;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace AppCalculadoraTestx
{
    [TestClass]
    public class OperacionText
    {
        [TestMethod]
        public void SumarSieteYCuatroROnce()
        {
            Operacion operacion = new Operacion();
            float resultado = operacion.Sumar(7, 4);
            Assert.AreEqual(resultado,11);
        }
    }
}
