using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apppoo.Interfaces
{
    public class Usuario : IMantenimiento
    {
        public bool Editar()
        {
            MessageBox.Show("Editando Usuario");
            return true;
        }

        public bool Insertar()
        {
            MessageBox.Show("OInsertando  Usuario");
            return true;
        }
    }
}
