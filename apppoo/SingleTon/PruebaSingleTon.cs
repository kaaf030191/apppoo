using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apppoo.SingleTon
{
    public partial class PruebaSingleTon : Form
    {
        public PruebaSingleTon()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SingleTon.getInstance.saludar("SVS"));
        }


        private void btnInsertPersona_Click(object sender, EventArgs e)
        {
            IMantenimiento p = new Persona();
            p.insertar();
        }

        private void btnEditPersona_Click(object sender, EventArgs e)
        {
            IMantenimiento p = new Persona();
            p.editar();
        }

        private void btnInsertUsuario_Click(object sender, EventArgs e)
        {
            IMantenimiento p = new Usuario();
            p.editar();
        }

        private void btnEditUsuario_Click(object sender, EventArgs e)
        {
            IMantenimiento p = new Usuario();
            p.editar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Padre hijo2 = new Padre((Interface2)new Hijo2());

            hijo2.insertar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Padre hijo2 = new Padre((Interface1)new Hijo2());

            hijo2.saludar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Padre hijo1 = new Padre(new Hijo1());

            hijo1.saludar();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Padre hijo3 = new Padre(new Hijo3());

            hijo3.insertar();
        }

    }
}
