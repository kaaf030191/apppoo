using System;
namespace AppCalculadora
{
    public class Operacion:IOperacion
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
