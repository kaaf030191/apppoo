using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apppoo.SingleTon
{
    class Persona:IMantenimiento
    {
        public bool insertar()
        {
            MessageBox.Show("Insertado Persona");
            return true;
        }
        public bool editar()
        {
            MessageBox.Show("Editado Persona");
            return true;
        }
    }
}
