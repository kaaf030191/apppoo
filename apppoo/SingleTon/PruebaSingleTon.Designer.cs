namespace apppoo.SingleTon
{
    partial class PruebaSingleTon
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnInsertPersona = new System.Windows.Forms.Button();
            this.btnEditPersona = new System.Windows.Forms.Button();
            this.btnEditUsuario = new System.Windows.Forms.Button();
            this.btnInsertUsuario = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(12, 12);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(260, 23);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnInsertPersona
            // 
            this.btnInsertPersona.Location = new System.Drawing.Point(11, 69);
            this.btnInsertPersona.Name = "btnInsertPersona";
            this.btnInsertPersona.Size = new System.Drawing.Size(260, 23);
            this.btnInsertPersona.TabIndex = 1;
            this.btnInsertPersona.Text = "Insertar Persona";
            this.btnInsertPersona.UseVisualStyleBackColor = true;
            this.btnInsertPersona.Click += new System.EventHandler(this.btnInsertPersona_Click);
            // 
            // btnEditPersona
            // 
            this.btnEditPersona.Location = new System.Drawing.Point(12, 98);
            this.btnEditPersona.Name = "btnEditPersona";
            this.btnEditPersona.Size = new System.Drawing.Size(260, 23);
            this.btnEditPersona.TabIndex = 2;
            this.btnEditPersona.Text = "Editar Persona";
            this.btnEditPersona.UseVisualStyleBackColor = true;
            this.btnEditPersona.Click += new System.EventHandler(this.btnEditPersona_Click);
            // 
            // btnEditUsuario
            // 
            this.btnEditUsuario.Location = new System.Drawing.Point(12, 175);
            this.btnEditUsuario.Name = "btnEditUsuario";
            this.btnEditUsuario.Size = new System.Drawing.Size(260, 23);
            this.btnEditUsuario.TabIndex = 4;
            this.btnEditUsuario.Text = "Editar Usuario";
            this.btnEditUsuario.UseVisualStyleBackColor = true;
            this.btnEditUsuario.Click += new System.EventHandler(this.btnEditUsuario_Click);
            // 
            // btnInsertUsuario
            // 
            this.btnInsertUsuario.Location = new System.Drawing.Point(11, 146);
            this.btnInsertUsuario.Name = "btnInsertUsuario";
            this.btnInsertUsuario.Size = new System.Drawing.Size(260, 23);
            this.btnInsertUsuario.TabIndex = 3;
            this.btnInsertUsuario.Text = "Insertar Usuario";
            this.btnInsertUsuario.UseVisualStyleBackColor = true;
            this.btnInsertUsuario.Click += new System.EventHandler(this.btnInsertUsuario_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(443, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Saludar[Hijo1]";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(443, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Saludar[Hijo2]";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(443, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Insertar [Hijo2]";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(443, 195);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(260, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Insertar [Hijo3]";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // PruebaSingleTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 249);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditUsuario);
            this.Controls.Add(this.btnInsertUsuario);
            this.Controls.Add(this.btnEditPersona);
            this.Controls.Add(this.btnInsertPersona);
            this.Controls.Add(this.btnMostrar);
            this.Name = "PruebaSingleTon";
            this.Text = "PruebaSingleTon";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnInsertPersona;
        private System.Windows.Forms.Button btnEditPersona;
        private System.Windows.Forms.Button btnEditUsuario;
        private System.Windows.Forms.Button btnInsertUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}