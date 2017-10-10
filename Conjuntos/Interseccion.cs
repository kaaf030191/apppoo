using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjuntos
{
    public class Interseccion
    {
        public static int[] CalcularInterseccion(int[] arrayA, int[] arrayB)
        {
            int[] arrayC = new int[10];
            int da = 0, cont = 0;
            for (int i = 0; i < arrayA.Length; i++)
            {
                for (int j = 0; j < arrayB.Length; j++)
                {
                    if (arrayA[i] == arrayB[j])
                    {
                        arrayC[da] = arrayA[i];
                        cont++;
                        //return arrayC[da];
                        //Console.Write(arrayC[da] + "___");
                    }
                    //return arrayC;
                }
               
            }
            return arrayC;
        }
    }
}
