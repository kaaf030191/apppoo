using System.Collections.Generic;
using System.Linq;

namespace AppOperacionesConjuntos
{
    public class OperacionesConjuntos : IOperaciones
    {
        public List<int> Union(List<int> conjunto1, List<int> conjunto2)
        {
            List<int> conjuntoUnion = conjunto1.Concat(conjunto2).ToList<int>();

            conjuntoUnion = conjuntoUnion.Distinct().ToList<int>();

            return conjuntoUnion;
        }

        public List<int> Interseccion(List<int> conjunto1, List<int> conjunto2)
        {
            List<int> conjuntoInterseccion = new List<int>();

            foreach (var item in conjunto1)
            {
                if (conjunto2.Contains(item))
                {
                    conjuntoInterseccion.Add(item);
                }
            }
            conjuntoInterseccion = conjuntoInterseccion.Distinct().ToList<int>();

            return conjuntoInterseccion;

        }
    }
}
