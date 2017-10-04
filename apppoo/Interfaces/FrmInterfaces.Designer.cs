namespace apppoo.Interfaces
{
    partial class FrmInterfaces
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
            this.btnInterface = new System.Windows.Forms.Button();
            this.btnIUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInterface
            // 
            this.btnInterface.Location = new System.Drawing.Point(56, 99);
            this.btnInterface.Name = "btnInterface";
            this.btnInterface.Size = new System.Drawing.Size(75, 23);
            this.btnInterface.TabIndex = 0;
            this.btnInterface.Text = "IMprimirPersona";
            this.btnInterface.UseVisualStyleBackColor = true;
            this.btnInterface.Click += new System.EventHandler(this.btnInterface_Click);
            // 
            // btnIUsuario
            // 
            this.btnIUsuario.Location = new System.Drawing.Point(137, 99);
            this.btnIUsuario.Name = "btnIUsuario";
            this.btnIUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnIUsuario.TabIndex = 1;
            this.btnIUsuario.Text = "IMprimirUsuario";
            this.btnIUsuario.UseVisualStyleBackColor = true;
            this.btnIUsuario.Click += new System.EventHandler(this.btnIUsuario_Click);
            // 
            // FrmInterfaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnIUsuario);
            this.Controls.Add(this.btnInterface);
            this.Name = "FrmInterfaces";
            this.Text = "FrmInterfaces";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInterface;
        private System.Windows.Forms.Button btnIUsuario;
    }
}