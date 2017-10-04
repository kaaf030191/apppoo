using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apppoo.Interfaces
{
    public partial class FrmInterfaces : Form
    {
        public FrmInterfaces()
        {
            InitializeComponent();
        }

        private void btnInterface_Click(object sender, EventArgs e)
        {
            Persona1 Persona= new Persona1();
            Persona.Insertar();
        }

        private void btnIUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
