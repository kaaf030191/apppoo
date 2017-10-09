using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apppoo.Interfaces.Clase_1
{
    public class Clase2 : General, IInterface1, IInterface2
    {
        public bool Editar()
        {
            MessageBox.Show("Editando clase 2");
            return true;
        }

        public bool Eliminar()
        {
            MessageBox.Show("Elimnado clase 2");
            return true;
        }

        public bool Insertar()
        {
            MessageBox.Show("Insertanado clase 1");
            return true;
        }
    }
}
