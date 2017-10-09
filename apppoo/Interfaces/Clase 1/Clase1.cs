using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apppoo.Interfaces.Clase_1
{
    public class Clase1 : General, IInterface1
    {
        public bool Editar()
        {
            MessageBox.Show("Editando clase 1");
            return true;
        }

        public bool Insertar()
        {
            MessageBox.Show("Insertando clase 1");
            return true;
        }
    }
}
