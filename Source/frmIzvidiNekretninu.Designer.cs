namespace PraviProjekatBerza
{
    partial class frmIzvidiNekretninu
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
            this.pnlNekretnina = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlNekretnina
            // 
            this.pnlNekretnina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNekretnina.Location = new System.Drawing.Point(0, 0);
            this.pnlNekretnina.Name = "pnlNekretnina";
            this.pnlNekretnina.Size = new System.Drawing.Size(354, 327);
            this.pnlNekretnina.TabIndex = 0;
            this.pnlNekretnina.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNekretnina_Paint);
            // 
            // frmIzvidiNekretninu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 327);
            this.Controls.Add(this.pnlNekretnina);
            this.Name = "frmIzvidiNekretninu";
            this.Text = "frmIzvidiNekretninu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNekretnina;
    }
}