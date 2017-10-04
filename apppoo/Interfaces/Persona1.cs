using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apppoo.Interfaces
{
    public class Persona1 : IMantenimiento
    {
        public bool Editar()
        {
            MessageBox.Show("Insertando persona");
            return true;
            
        }

        public bool Insertar()
        {
            MessageBox.Show("Editando Persona");
            return true;
        }
    }
}
