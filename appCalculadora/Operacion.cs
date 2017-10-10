using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace appCalculadora
{
    public class Operacion : IOperacion
    {
        public float Sumar(float numeroUno, float numeroDos)
        {
            return numeroUno + numeroDos;
        }

        public float Restar(float numeroUno, float numeroDos)
        {
            throw new NotImplementedException();
        }
    }
}