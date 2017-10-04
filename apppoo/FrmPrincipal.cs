using apppoo.Object;
using apppoo.Query;
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
        List<PersonaNatural> listaPersonaNatural;
        List<PersonaJuridica> listaPersonaJuridica;

        public FrmPrincipal()
        {
            listaPersonaNatural=new List<PersonaNatural>();
            listaPersonaJuridica = new List<PersonaJuridica>();

            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //PersonaNatural personaNatural = new PersonaNatural();

            //personaNatural.nombre = "Carlos Sarmiento Aranibar";

            //lblNombre.Text = personaNatural.nombre;

            //QPersona qPersona = new QPersona();

            //qPersona.insertar();

            //QPersona qPersonaNatural = new QPersonaNatural();
            //QPersona qPersonaJuridica = new QPersonaJuridica();

            //qPersonaNatural.insertar();
            //qPersonaJuridica.insertar();

            string nombre="Carlos";
            string direccion="Av. Cáceres";
            string telefono="987987988";
            string correoElectronico="carlos@gmail.com";
            string apellido = "Cáceres Alcides";
            string dni = "77777777";
            string fechaNacimiento = "1991/01/01";
            bool sexo = true;

            PersonaNatural personaNatural = new PersonaNatural();

            personaNatural.nombre = nombre;
            personaNatural.direccion = direccion;
            personaNatural.telefono = telefono;
            personaNatural.correoElectronico = correoElectronico;
            personaNatural.apellido=apellido;
            personaNatural.dni=dni;
            personaNatural.fechaNacimiento=fechaNacimiento;
            personaNatural.sexo=sexo;

            QPersona qPersona = new QPersonaNatural();

            qPersona.insertarPersonaNatural(personaNatural, ref listaPersonaNatural);

            foreach (var item in listaPersonaNatural)
            {
                MessageBox.Show(item.nombre);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string correoElectronico = txtCorreo.Text;
            string apellido = txtApellido.Text;
            string dni = txtDni.Text;
            string fechaNacimiento = txtFechaNacimiento.Text;
            bool sexo = txtSexo.Text=="M" ? true : false;

            PersonaNatural personaNatural = new PersonaNatural();

            personaNatural.nombre = nombre;
            personaNatural.direccion = direccion;
            personaNatural.telefono = telefono;
            personaNatural.correoElectronico = correoElectronico;
            personaNatural.apellido = apellido;
            personaNatural.dni = dni;
            personaNatural.fechaNacimiento = fechaNacimiento;
            personaNatural.sexo = sexo;

            QPersona qPersona = new QPersonaNatural();

            qPersona.insertarPersonaNatural(personaNatural, ref listaPersonaNatural);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QPersona qPersona = new QPersonaNatural();

            dataGridView1.DataSource = null;

            qPersona.listarPersona(listaPersonaNatural, listaPersonaJuridica, ref dataGridView1);

            dataGridView1.Refresh();
        }
    }
}
