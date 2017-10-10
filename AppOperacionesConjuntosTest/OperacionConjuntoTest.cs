using AppOperacionesConjuntos;
using NUnit.Framework;
using System.Collections.Generic;
namespace AppOperacionesConjuntosTest
{
    [TestFixture]
    public class OperacionConjuntoTest
    {
        IOperaciones operacion;

        [SetUp]
        public void Init()
        {
            operacion = new OperacionesConjuntos();
        }

        [TestCase]
        public void UnionConjuntosTest1()
        {
            List<int> conjunto1 = new List<int>(new int[] { -1, 2, 3, 4 });
            List<int> conjunto2 = new List<int>(new int[] { 1, -1, 1, 2, 2, 2 });
            List<int> resultado = operacion.Union(conjunto1, conjunto2);

            Assert.That(resultado, Is.EquivalentTo(new List<int>(new int[] { 1, -1, 2, 3, 4 })));
        }

        [TestCase]
        public void InterseccionConjuntosTest1()
        {
            List<int> conjunto1 = new List<int>(new int[] { 1, 2, 3, 4 });
            List<int> conjunto2 = new List<int>(new int[] { 1, 1, 1, 2, 2, 2 });
            List<int> resultado = operacion.Interseccion(conjunto1, conjunto2);

            Assert.That(resultado, Is.EquivalentTo(new List<int>(new int[] { 1, 2 })));
        }

        [TearDown]
        public void Finish()
        {
            operacion = null;
        }
    }
}
