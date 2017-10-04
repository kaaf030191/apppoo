using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apppoo.Interfaces.Clase_1
{
    public class Clase3 : General, IInterface2
    {
        public bool Eliminar()
        {
            MessageBox.Show("Editando clase 3");
            return true;
        }
    }
}
