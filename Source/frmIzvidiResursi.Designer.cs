namespace PraviProjekatBerza
{
    partial class frmResurs
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
            this.pnlResurs = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlResurs
            // 
            this.pnlResurs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResurs.Location = new System.Drawing.Point(0, 0);
            this.pnlResurs.Name = "pnlResurs";
            this.pnlResurs.Size = new System.Drawing.Size(356, 327);
            this.pnlResurs.TabIndex = 0;
            this.pnlResurs.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlResurs_Paint);
            // 
            // frmResurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 327);
            this.Controls.Add(this.pnlResurs);
            this.Name = "frmResurs";
            this.Text = "IzvidiResurs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlResurs;
    }
}