using Conjuntos;
using NUnit.Framework;
namespace ConjuntoTest
{
    [TestFixture]
    public class InterseccionTest
    {
        Interseccion interseccion = null;
        [SetUp]
        public void Init()
        {
            interseccion = new Interseccion();
        }

        [TestCase]
        public void InterseccionArreglo()
        {
            int[] ArregloC = Interseccion.CalcularInterseccion(new[] { 2, 2, 1 }, new[] { 2, 3, 4 });
            Assert.That(ArregloC, Is.EqualTo(new[] { 2 }));
        }
        [TearDown]
        public void Finish()
        {
            interseccion = null;
        }
    }
}
