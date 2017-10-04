using apppoo.Object;
using apppoo.Query;
using System.Collections.Generic;
using System.Windows.Forms;

namespace apppoo
{
    public partial class FrmPrinsipal : Form
    {
        List<PersonaNatural> listaPersonaNatural;
        List<PersonaJuridica> listaPersonaJuridica;

        public FrmPrinsipal()
        {
            listaPersonaJuridica = new List<PersonaJuridica>();
            listaPersonaNatural = new List<PersonaNatural>();
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (SelectTipoPersona.Items[0].ToString() == "1")
            {
                PersonaNatural personaNatural = new PersonaNatural();
                personaNatural.nombre = txtNombre.Text;
                personaNatural.apellido = txtApellido.Text;
                personaNatural.telefono = txtEmail.Text;
                personaNatural.direcion = txtDirecion.Text;
                personaNatural.sexo = true;
                personaNatural.fechaNacimiento = "12/7/2000";

                QPersona qPersona = new QPersonaNatural();
                qPersona.insertarPersonaNatural(personaNatural, ref listaPersonaNatural);

            }
            else
            {

                PersonaJuridica personaJuridica = new PersonaJuridica();
                personaJuridica.nombre = txtNombre.Text;
                personaJuridica.ruc = txtApellido.Text;
                personaJuridica.telefono = txtEmail.Text;
                personaJuridica.direcion = txtDirecion.Text;
                personaJuridica.paginaWeb = txtPaginaWeb.Text;


            }
        }

        private void btnListar_Click(object sender, System.EventArgs e)
        {
            QPersona qPersona = new QPersonaNatural();

            dgvData.DataSource = null;

            qPersona.ListarPersona(listaPersonaNatural, listaPersonaJuridica, ref dgvData);

            dgvData.Refresh();
        }
    }
}
