using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apppoo.NewFolder1
{
    class cl_1
    {
        private static cl_1 p;
        public cl_1()
        {
            System.Windows.Forms.MessageBox.Show("Nuevo Singleton");
        }
        

    public  static cl_1 Getinstace
        {
            get
            {
                if (p==null)
                {
                    p = new cl_1();
                }
                return p;
            }


        }

        public string saludar(string nombre)
        {
            return "hola" + nombre;
        }

        string x = cl_1.Getinstace().saludar("svs");
    }
}
