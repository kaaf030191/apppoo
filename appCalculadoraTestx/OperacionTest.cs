
using AppCalculadora;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace appCalculadoraTestx
{   [TestClass]
    public class OperacionTest
    {
    [TestMethod]//patrones  de diseños estructurales 
    public void SumarSieteYCuatroROnce()
    {
        Operacion operacion = new Operacion();
        float resultado = operacion.Sumar(7, 4);
        Assert.AreEqual(resultado, 11);

    }

    }
}
