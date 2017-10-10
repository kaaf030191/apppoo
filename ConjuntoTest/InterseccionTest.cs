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
            int[] ArregloC = Interseccion.CalcularInterseccion(new[] { 1, 2, 3, 4, }, new[] { 2, 3, 5, 3 });
            Assert.That(ArregloC, Is.EqualTo(new[] { 2,3,3,3,3 }));
        }
        [TearDown]
        public void Finish()
        {
            interseccion = null;
        }
    }
}
