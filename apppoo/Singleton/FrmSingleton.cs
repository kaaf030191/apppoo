using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apppoo.Singleton
{
    public partial class FrmSingleton : Form
    {
        public FrmSingleton()
        {
            InitializeComponent();
        }

        private void btSingleton_Click(object sender, EventArgs e)
        {
            string xyz = Practicante.GetInstance.Saludar("Lucho");
            MessageBox.Show(xyz);
        }
    }
}
