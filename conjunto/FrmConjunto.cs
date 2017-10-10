using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conjunto
{
    public partial class FrmConjunto : Form
    {
        public FrmConjunto()
        {
            InitializeComponent();
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            UnionConjunto unionConjunto = new UnionConjunto();

           // unionConjunto.UnionionConjuntoAYConjuntoB();
        }
    }
}
