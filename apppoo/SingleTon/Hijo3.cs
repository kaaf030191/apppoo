using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apppoo.SingleTon
{
    class Hijo3:Padre,Interface2
    {
        public void insertar()
        {
            MessageBox.Show("Insertando desde clase Hija 3");
        }
    }
}
