namespace apppoo.Singleton
{
    partial class FrmSingleton
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
            this.btSingleton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSingleton
            // 
            this.btSingleton.Location = new System.Drawing.Point(101, 97);
            this.btSingleton.Name = "btSingleton";
            this.btSingleton.Size = new System.Drawing.Size(75, 18);
            this.btSingleton.TabIndex = 0;
            this.btSingleton.Text = "Singleton";
            this.btSingleton.UseVisualStyleBackColor = true;
            this.btSingleton.Click += new System.EventHandler(this.btSingleton_Click);
            // 
            // FrmSingleton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btSingleton);
            this.Name = "FrmSingleton";
            this.Text = "Singleton";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSingleton;
    }
}