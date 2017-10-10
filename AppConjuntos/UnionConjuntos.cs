using System.Linq;
using System.Collections.Generic;
namespace AppConjuntos
{
    public class UnionConjuntos
    {
        public List<int> unionCojunto(List<int> conjuntoA, List<int> conjuntoB)
        {
            List<int> listaCojuntoUnion= conjuntoA.Concat(conjuntoB).ToList<int>();
            listaCojuntoUnion=listaCojuntoUnion.Distinct().ToList<int>();
            return listaCojuntoUnion;
        }

    }
}
