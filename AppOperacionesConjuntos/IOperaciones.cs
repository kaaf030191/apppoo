
using System.Collections.Generic;
namespace AppOperacionesConjuntos
{
    public interface IOperaciones
    {
        List<int> Union(List<int> conjunto1, List<int> conjunto2);
        List<int> Interseccion(List<int> conjunto1, List<int> conjunto2);
    }
}
