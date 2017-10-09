using AppCalculadora;
using NUnit.Framework;

namespace appcalculadoratest
{
    [TestFixture]
    public class OperacionTest
    {
        Operacion operacion = null;
        [SetUp]
        public void Init()
        {
            operacion = new Operacion();
        }

        [TestCase]
        public void SumarSieteYCuatroROnce()
        {
            float resultado = operacion.Sumar(7, 4);

            Assert.That(resultado, Is.EqualTo(9)); 
        }
        [TestCase]
        public void SumarSieteYSieteROnce()
        {
            float resultado = operacion.Sumar(7, 7);

            Assert.That(resultado, Is.EqualTo(14));
        }
        [TearDown]
        public void finish()
        {
            operacion = null;
        }

    }
}
