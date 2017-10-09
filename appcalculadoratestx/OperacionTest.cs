using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appcalculadora;
namespace appcalculadoratestx
{
    [TestClass]
    public class OperacionTest
    {
        [TestMethod] //patrones de diseño estructurales
        public void SumarSieteYCuatroROnce()
        {
            operacion Operacion = new operacion();
            float resultado = Operacion.Suma(7,4);
            Assert.AreEqual(resultado, 11);
        }
    }
}
