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
            string mensaje = SelectTipoPersona.SelectedItem.ToString();
            MessageBox.Show(mensaje);

            if (SelectTipoPersona.SelectedItem.ToString() == "Persona Natural")
            {
                PersonaNatural personaNatural = new PersonaNatural();
                personaNatural.nombre = txtNombre.Text;
                personaNatural.apellido = txtApellido.Text;
                personaNatural.telefono = txtEmail.Text;
                personaNatural.direcion = txtDirecion.Text;
                personaNatural.sexo = true;
                personaNatural.fechaNacimiento = "12/7/2000";
                personaNatural.correoElectronico = txtCorreoElectronico.Text;

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
                personaJuridica.correoElectronico = txtCorreoElectronico.Text;

                QPersona qpersonaJuridica = new QPersonaJuridica();
                qpersonaJuridica.insertarPersonaJuridica(personaJuridica, ref listaPersonaJuridica);


            }
        }

        private void btnListar_Click(object sender, System.EventArgs e)
        {
            QPersona qPersona = new QPersonaNatural();
            QPersona qPersonaJ = new QPersonaJuridica();

            dgvData.DataSource = null;

            if (SelectTipoPersona.SelectedItem.ToString() == "Persona Natural")
            {
                qPersona.ListarPersona(listaPersonaNatural, listaPersonaJuridica, ref dgvData);
                dgvData.Refresh();
            }
            else
            {
                qPersonaJ.ListarPersona(listaPersonaNatural, listaPersonaJuridica, ref dgvData);
                dgvData.Refresh();
            } 
        }
    }
}
