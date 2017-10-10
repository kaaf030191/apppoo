using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculadora
{
   public  interface IOperacion
    {
        float Sumar(float numeroUno, float numeroDos);
        float Restar(float numeroUno, float numeroDos);
       
    }
}
