namespace conjunto
{
    partial class FrmConjunto
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
            this.btnver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnver
            // 
            this.btnver.Location = new System.Drawing.Point(81, 129);
            this.btnver.Name = "btnver";
            this.btnver.Size = new System.Drawing.Size(75, 23);
            this.btnver.TabIndex = 0;
            this.btnver.Text = "ver";
            this.btnver.UseVisualStyleBackColor = true;
            this.btnver.Click += new System.EventHandler(this.btnver_Click);
            // 
            // FrmConjunto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnver);
            this.Name = "FrmConjunto";
            this.Text = "FrmConjunto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnver;
    }
}