namespace apppoo
{
    partial class frmAgregarPersona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtnPersonaNatural = new System.Windows.Forms.RadioButton();
            this.rbtnPersonaJuridica = new System.Windows.Forms.RadioButton();
            this.gbPersonaNatural = new System.Windows.Forms.GroupBox();
            this.rbSMujer = new System.Windows.Forms.RadioButton();
            this.rbSVaron = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbPersonaJuridica = new System.Windows.Forms.GroupBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.gbPersonaNatural.SuspendLayout();
            this.gbPersonaJuridica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo persona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(85, 87);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(85, 113);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Direccion";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(85, 139);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefono";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(85, 165);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // rbtnPersonaNatural
            // 
            this.rbtnPersonaNatural.AutoSize = true;
            this.rbtnPersonaNatural.Checked = true;
            this.rbtnPersonaNatural.Location = new System.Drawing.Point(27, 45);
            this.rbtnPersonaNatural.Name = "rbtnPersonaNatural";
            this.rbtnPersonaNatural.Size = new System.Drawing.Size(101, 17);
            this.rbtnPersonaNatural.TabIndex = 11;
            this.rbtnPersonaNatural.TabStop = true;
            this.rbtnPersonaNatural.Text = "Persona Natural";
            this.rbtnPersonaNatural.UseVisualStyleBackColor = true;
            this.rbtnPersonaNatural.CheckedChanged += new System.EventHandler(this.rbtnPersonaNatural_CheckedChanged);
            // 
            // rbtnPersonaJuridica
            // 
            this.rbtnPersonaJuridica.AutoSize = true;
            this.rbtnPersonaJuridica.Location = new System.Drawing.Point(172, 45);
            this.rbtnPersonaJuridica.Name = "rbtnPersonaJuridica";
            this.rbtnPersonaJuridica.Size = new System.Drawing.Size(103, 17);
            this.rbtnPersonaJuridica.TabIndex = 12;
            this.rbtnPersonaJuridica.Text = "Persona Juridica";
            this.rbtnPersonaJuridica.UseVisualStyleBackColor = true;
            this.rbtnPersonaJuridica.CheckedChanged += new System.EventHandler(this.rbtnPersonaJuridica_CheckedChanged);
            // 
            // gbPersonaNatural
            // 
            this.gbPersonaNatural.Controls.Add(this.rbSMujer);
            this.gbPersonaNatural.Controls.Add(this.rbSVaron);
            this.gbPersonaNatural.Controls.Add(this.label9);
            this.gbPersonaNatural.Controls.Add(this.txtFechaNacimiento);
            this.gbPersonaNatural.Controls.Add(this.label8);
            this.gbPersonaNatural.Controls.Add(this.txtDni);
            this.gbPersonaNatural.Controls.Add(this.label7);
            this.gbPersonaNatural.Controls.Add(this.txtApellido);
            this.gbPersonaNatural.Controls.Add(this.label6);
            this.gbPersonaNatural.Location = new System.Drawing.Point(20, 222);
            this.gbPersonaNatural.Name = "gbPersonaNatural";
            this.gbPersonaNatural.Size = new System.Drawing.Size(255, 162);
            this.gbPersonaNatural.TabIndex = 13;
            this.gbPersonaNatural.TabStop = false;
            this.gbPersonaNatural.Text = "Persona Natrual";
            // 
            // rbSMujer
            // 
            this.rbSMujer.AutoSize = true;
            this.rbSMujer.Location = new System.Drawing.Point(152, 117);
            this.rbSMujer.Name = "rbSMujer";
            this.rbSMujer.Size = new System.Drawing.Size(51, 17);
            this.rbSMujer.TabIndex = 13;
            this.rbSMujer.TabStop = true;
            this.rbSMujer.Text = "Mujer";
            this.rbSMujer.UseVisualStyleBackColor = true;
            // 
            // rbSVaron
            // 
            this.rbSVaron.AutoSize = true;
            this.rbSVaron.Checked = true;
            this.rbSVaron.Location = new System.Drawing.Point(80, 117);
            this.rbSVaron.Name = "rbSVaron";
            this.rbSVaron.Size = new System.Drawing.Size(53, 17);
            this.rbSVaron.TabIndex = 12;
            this.rbSVaron.TabStop = true;
            this.rbSVaron.Text = "Varon";
            this.rbSVaron.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Sexo";
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(78, 80);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.txtFechaNacimiento.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Fecha N.";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(78, 54);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Dni";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(78, 28);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Apellido";
            // 
            // gbPersonaJuridica
            // 
            this.gbPersonaJuridica.Controls.Add(this.txtUrl);
            this.gbPersonaJuridica.Controls.Add(this.label11);
            this.gbPersonaJuridica.Controls.Add(this.txtRuc);
            this.gbPersonaJuridica.Controls.Add(this.label10);
            this.gbPersonaJuridica.Enabled = false;
            this.gbPersonaJuridica.Location = new System.Drawing.Point(297, 222);
            this.gbPersonaJuridica.Name = "gbPersonaJuridica";
            this.gbPersonaJuridica.Size = new System.Drawing.Size(255, 162);
            this.gbPersonaJuridica.TabIndex = 14;
            this.gbPersonaJuridica.TabStop = false;
            this.gbPersonaJuridica.Text = "Persona Juridica";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(88, 54);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(100, 20);
            this.txtUrl.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Url";
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(88, 28);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(100, 20);
            this.txtRuc.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Ruc";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(385, 119);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 15;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(385, 90);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 16;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(20, 390);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(532, 221);
            this.dgvLista.TabIndex = 17;
            // 
            // frmAgregarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 615);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.gbPersonaJuridica);
            this.Controls.Add(this.gbPersonaNatural);
            this.Controls.Add(this.rbtnPersonaJuridica);
            this.Controls.Add(this.rbtnPersonaNatural);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAgregarPersona";
            this.Text = "frmAgregarPersona";
            this.gbPersonaNatural.ResumeLayout(false);
            this.gbPersonaNatural.PerformLayout();
            this.gbPersonaJuridica.ResumeLayout(false);
            this.gbPersonaJuridica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtnPersonaNatural;
        private System.Windows.Forms.RadioButton rbtnPersonaJuridica;
        private System.Windows.Forms.GroupBox gbPersonaNatural;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbPersonaJuridica;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbSMujer;
        private System.Windows.Forms.RadioButton rbSVaron;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvLista;
    }
}