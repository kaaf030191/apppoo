using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apppoo.SingleTon
{
    class Hijo1:Padre,Interface1
    {
        public void saludar()
        {
            MessageBox.Show("Hola soy la clase Hija1");
        }
    }
}
