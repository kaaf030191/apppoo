using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apppoo.SingleTon
{
    class Hijo2:Padre,Interface1, Interface2
    {
        public void saludar()
        {
            MessageBox.Show("Hola soy la clase Hija2");
        }
        public void insertar()
        {
            MessageBox.Show("Insertando desde la clases Hija2");
        }
    }
}
