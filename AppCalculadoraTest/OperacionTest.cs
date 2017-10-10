using AppCalculadora;
using Moq;
using NUnit.Framework;

namespace appcalculadoratest
{
    [TestFixture]
    public class OperacionTest
    {
        IOperacion operacion = null;

        [SetUp]
        public void Init()
        {
            operacion = new Operacion();
        }

        #region UT Sumar

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

        #endregion

        #region UT Restar

        [TestCase]
        public void RestarSieteYCuatroRTres()
        {
            Mock<IOperacion> moq = new Mock<IOperacion>();

            moq.Setup(x => x.Restar(7, 4)).Returns(3);

            float resultado = moq.Object.Restar(7, 4);

            Assert.That(resultado, Is.EqualTo(3));
        }

        #endregion

        [TearDown]
        public void Finish()
        {
            operacion = null;
        }
    }
}