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
    public partial class frmAgregarPersona : Form
    {
        List<PersonaNatural> listaPersonaNatural;
        List<PersonaJuridica> listaPersonaJuridica;
        public frmAgregarPersona()
        {
            listaPersonaNatural = new List<PersonaNatural>();
            listaPersonaJuridica = new List<PersonaJuridica>();
            InitializeComponent();
        }

        private void rbtnPersonaNatural_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPersonaNatural.Checked)
            {
                gbPersonaJuridica.Enabled = false;
                gbPersonaNatural.Enabled = true;
            }
                
        }

        private void rbtnPersonaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPersonaJuridica.Checked)
            {
                gbPersonaJuridica.Enabled = true;
                gbPersonaNatural.Enabled = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {


            if (rbtnPersonaJuridica.Checked)
            {
                PersonaJuridica p = new PersonaJuridica();
                p.nombre = txtNombre.Text;
                p.dirección = txtDireccion.Text;
                p.telefono = txtTelefono.Text;
                p.correo_electronico = txtEmail.Text;

                p.ruc = txtRuc.Text;
                p.url_pagina_web = txtUrl.Text;

                EntityPersona EPersonaJuridica = new EntitiyPersonaJuridica();
                EPersonaJuridica.insertarPersonaJuridica(p, ref listaPersonaJuridica);

            }
            else if (rbtnPersonaNatural.Checked)
            {
                PersonaNatural p = new PersonaNatural();
                p.nombre = txtNombre.Text;
                p.dirección = txtDireccion.Text;
                p.telefono = txtTelefono.Text;
                p.correo_electronico = txtEmail.Text;

                p.apellido = txtApellido.Text;
                p.dni = txtDni.Text;
                p.fecha_nacimiento = txtFechaNacimiento.Text;

                if (rbSVaron.Checked)
                    p.sexo = true;
                else if (rbSMujer.Checked)
                    p.sexo = false;

                EntityPersona EPersonaNatural = new EntityPersonaNatural();
                EPersonaNatural.insertarPersonaNatural(p, ref listaPersonaNatural);
                
            }
            limpiar_campos();
            MessageBox.Show("Persona ah sido registrada");
            
           
        }

        private void limpiar_campos()
        {
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtDni.Text = "";
            txtEmail.Text = "";
            txtFechaNacimiento.Text = "";
            txtNombre.Text = "";
            txtRuc.Text = "";
            txtTelefono.Text = "";
            txtUrl.Text = "";
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (rbtnPersonaJuridica.Checked)
            {
                dgvLista.DataSource = null;
                dgvLista.DataSource = listaPersonaJuridica;
                
            }
            else if (rbtnPersonaNatural.Checked)
            {
                dgvLista.DataSource = null;
                dgvLista.DataSource = listaPersonaNatural;
                
            }
        }
    }
}
