using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conjunto
{
    public class UnionConjunto
    {
        ConjuntoA ConjuntoA = new ConjuntoA();

        List<ConjuntoA> listaConjuntoA = new List<ConjuntoA>();

        ConjuntoB conjuntoB = new ConjuntoB();

        List<ConjuntoB> listaConjuntoB = new List<ConjuntoB>();
        public void cargarDatos()
        {
            ConjuntoA.elementosA = 10;
            ConjuntoA.elementosA = 11;
            ConjuntoA.elementosA = 13;

            listaConjuntoA.Add(ConjuntoA);

            conjuntoB.elementosB = 11;
            conjuntoB.elementosB = 12;
            conjuntoB.elementosB = 13;

            listaConjuntoB.Add(conjuntoB);
        }

        /* public List<UnionConjunto> UnionionConjuntoAYConjuntoB()
         {
             List<float> lista = new List<float>();
             foreach (var conjuntoA in listaConjuntoA)
             {

                 foreach (var conjuntoB in listaConjuntoB)
                 {
                     if (ConjuntoA.elementosA == conjuntoB.elementosB)
                     {
                         lista = conjuntoB.elementosB.Equals;
                     }
                     else
                     {
                         lista = conjuntoB.elementosB;
                     }
                 }

             }
             return lista();
         }
         */

        public void UnionListaAyListaB()
        {
            var listB = new List<int> { 3, 4, 5 };
            var listA = new List<int> { 1, 2, 3, 4, 5 };
            var listFinal = listA.Union(listB);
        }

    }
}
