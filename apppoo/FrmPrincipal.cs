using apppoo.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apppoo
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            PersonaNatural personaNatural = new PersonaNatural();

            personaNatural.nombre = "Carlos Sarmiento Aranibar";

            lblNombre.Text = personaNatural.nombre;
        }
    }
}
