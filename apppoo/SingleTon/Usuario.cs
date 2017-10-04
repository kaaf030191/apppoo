using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apppoo.SingleTon
{
    class Usuario:IMantenimiento
    {
        public bool insertar()
        {
            MessageBox.Show("Insertado Usuario");
            return true;
        }
        public bool editar()
        {
            MessageBox.Show("Editado Usuario");
            return true;
        }
    }
}
