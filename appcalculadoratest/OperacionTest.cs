using NUnit.Framework;
using appcalculadora;
namespace appcalculadoratest
{
    [TestFixture]
    public class OperacionTest
    {
        operacion Operacion = null;

        [SetUp]
        public void Init()
        {
            Operacion = new operacion();
        }

        [TestCase]
        public void SumarSieteyCuatroROnce()
        {
            //operacion Operacion = new operacion();
            float resultado = Operacion.Suma(7, 4);
            Assert.That(resultado, Is.EqualTo(11));
        }



        public void SumarSieteyDiezRDiecisiete()
        {
            //operacion Operacion = new operacion();
            float resultado = Operacion.Suma(7, 10);
            Assert.That(resultado, Is.EqualTo(17));
        }


        [TearDown]
        public void Finish()
        {
            Operacion = null;
        }


    }


}
