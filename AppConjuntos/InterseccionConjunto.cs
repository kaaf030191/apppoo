using System.Collections.Generic;
using System.Linq;
namespace AppConjuntos
{
    public class InterseccionConjunto
    {
        public List<int> InterCojunto(List<int> conjuntoA, List<int> conjuntoB)
        {
            List<int> listaCojuntoInter = new List<int>();
            foreach(var item in conjuntoA)
            {
                if (conjuntoB.Contains(item))
                {
                    listaCojuntoInter.Add(item);
                }
            }
            listaCojuntoInter = listaCojuntoInter.Distinct().ToList<int>();
            return listaCojuntoInter;
        }
    }
}
