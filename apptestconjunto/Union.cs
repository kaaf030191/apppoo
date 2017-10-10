using conjunto;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace apptestconjunto
{
    [TestClass]
    public class Union
    {
        //decoradores patrones de diseño estructurales
        /* public void SumarSieteYCuatroROnce()
         {
             UnionConjunto unionConjunto   =new UnionConjunto();

             List<UnionConjunto> resultado = unionConjunto.UnionionConjuntoAYConjuntoB();
             Assert.AreEqual(11, resultado);
         }
         */
        [TestMethod]
        public void UnionDeConjuntosAYB()
        {
            UnionConjunto unionConjunto = new UnionConjunto();
            unionConjunto.UnionListaAyListaB();
            Assert.

        }


    }
}
