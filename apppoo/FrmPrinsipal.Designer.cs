namespace apppoo
{
    partial class FrmPrinsipal
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDirecion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDirecion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SelectTipoPersona = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lbRuc = new System.Windows.Forms.Label();
            this.lbPaginaweb = new System.Windows.Forms.Label();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.txtPaginaWeb = new System.Windows.Forms.TextBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(26, 43);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre";
            // 
            // lbDirecion
            // 
            this.lbDirecion.AutoSize = true;
            this.lbDirecion.Location = new System.Drawing.Point(29, 71);
            this.lbDirecion.Name = "lbDirecion";
            this.lbDirecion.Size = new System.Drawing.Size(44, 13);
            this.lbDirecion.TabIndex = 1;
            this.lbDirecion.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Direccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(99, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(99, 68);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 6;
            // 
            // txtDirecion
            // 
            this.txtDirecion.Location = new System.Drawing.Point(99, 100);
            this.txtDirecion.Name = "txtDirecion";
            this.txtDirecion.Size = new System.Drawing.Size(100, 20);
            this.txtDirecion.TabIndex = 7;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(99, 138);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(99, 171);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SelectTipoPersona
            // 
            this.SelectTipoPersona.FormattingEnabled = true;
            this.SelectTipoPersona.Items.AddRange(new object[] {
            "Persona Natural",
            "Persona Juridica"});
            this.SelectTipoPersona.Location = new System.Drawing.Point(302, 34);
            this.SelectTipoPersona.Name = "SelectTipoPersona";
            this.SelectTipoPersona.Size = new System.Drawing.Size(121, 21);
            this.SelectTipoPersona.TabIndex = 11;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(188, 283);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 12;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lbRuc
            // 
            this.lbRuc.AutoSize = true;
            this.lbRuc.Location = new System.Drawing.Point(32, 198);
            this.lbRuc.Name = "lbRuc";
            this.lbRuc.Size = new System.Drawing.Size(27, 13);
            this.lbRuc.TabIndex = 13;
            this.lbRuc.Text = "Ruc";
            // 
            // lbPaginaweb
            // 
            this.lbPaginaweb.AutoSize = true;
            this.lbPaginaweb.Location = new System.Drawing.Point(32, 225);
            this.lbPaginaweb.Name = "lbPaginaweb";
            this.lbPaginaweb.Size = new System.Drawing.Size(63, 13);
            this.lbPaginaweb.TabIndex = 14;
            this.lbPaginaweb.Text = "PaginaWeb";
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(99, 198);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(100, 20);
            this.txtRuc.TabIndex = 15;
            // 
            // txtPaginaWeb
            // 
            this.txtPaginaWeb.Location = new System.Drawing.Point(99, 225);
            this.txtPaginaWeb.Name = "txtPaginaWeb";
            this.txtPaginaWeb.Size = new System.Drawing.Size(100, 20);
            this.txtPaginaWeb.TabIndex = 16;
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(376, 103);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(304, 150);
            this.dgvData.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Correo Elctronico";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(99, 251);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(100, 20);
            this.txtCorreoElectronico.TabIndex = 19;
            // 
            // FrmPrinsipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 339);
            this.Controls.Add(this.txtCorreoElectronico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.txtPaginaWeb);
            this.Controls.Add(this.txtRuc);
            this.Controls.Add(this.lbPaginaweb);
            this.Controls.Add(this.lbRuc);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.SelectTipoPersona);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDirecion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbDirecion);
            this.Controls.Add(this.lbNombre);
            this.Name = "FrmPrinsipal";
            this.Text = "FrmPrinsipal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDirecion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDirecion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox SelectTipoPersona;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lbRuc;
        private System.Windows.Forms.Label lbPaginaweb;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.TextBox txtPaginaWeb;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
    }
}