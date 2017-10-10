using AppConjuntos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace AppConjuntosTest
{
    [TestFixture]
    class OperacionConjuntosTest
    {
        UnionConjuntos unionConjunto = null;
        
        [SetUp]
        public void Init()
        {
            unionConjunto = new UnionConjuntos();
        }

        [TestCase]
        public void UnirConjuntoAYConjuntoB()
        {
            List<int> conjuntoA = new List<int>(new int[] { -1, 2, 3, 4 });
            List<int> conjuntoB = new List<int>(new int[] { -1, 2, 6, 7, 8});
            List<int> resultado = unionConjunto.unionCojunto(conjuntoA, conjuntoB);
            Assert.That(resultado, Is.EquivalentTo(new List<int>(new int[] { -1, 2, 3, 4, 6, 7, 8 })));
        }

        [TearDown]
        public void Finish()
        {
            unionConjunto = null;
        }
       
    }
}
