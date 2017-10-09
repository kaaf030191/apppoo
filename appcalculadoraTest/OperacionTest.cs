using appCalculadora;
using NUnit.Framework;
namespace appcalculadoraTest
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

            Assert.That(resultado, Is.EqualTo(11));
        }

        [TestCase]
        public void SumarSieteYDiezRDiecisiete()
        {
            float resultado = operacion.Sumar(7, 10);

            Assert.That(resultado, Is.EqualTo(17));
        }

        [TearDown]
        public void Finish()
        {
            operacion = null;
        }
    }
}
