namespace PraviProjekatBerza
{
    partial class frmIzvidiAkciju
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
            this.pnlAkcija = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlAkcija
            // 
            this.pnlAkcija.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAkcija.Location = new System.Drawing.Point(0, 0);
            this.pnlAkcija.Name = "pnlAkcija";
            this.pnlAkcija.Size = new System.Drawing.Size(357, 328);
            this.pnlAkcija.TabIndex = 0;
            this.pnlAkcija.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAkcija_Paint);
            // 
            // frmIzvidiAkciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 328);
            this.Controls.Add(this.pnlAkcija);
            this.Name = "frmIzvidiAkciju";
            this.Text = "IzvidiAkciju";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAkcija;
    }
}