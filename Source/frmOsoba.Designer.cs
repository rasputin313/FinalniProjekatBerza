namespace PraviProjekatBerza
{
    partial class frmOsoba
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
            this.cbAkcija = new System.Windows.Forms.ComboBox();
            this.cbNekretnine = new System.Windows.Forms.ComboBox();
            this.cbResursi = new System.Windows.Forms.ComboBox();
            this.pnlBerza = new System.Windows.Forms.Panel();
            this.btnNekretnineIzvidi = new System.Windows.Forms.Button();
            this.btnResursiIzvidi = new System.Windows.Forms.Button();
            this.btnAkcijeVidi = new System.Windows.Forms.Button();
            this.btnBerza = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.pnlBerza.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbAkcija
            // 
            this.cbAkcija.FormattingEnabled = true;
            this.cbAkcija.Location = new System.Drawing.Point(63, 144);
            this.cbAkcija.Margin = new System.Windows.Forms.Padding(4);
            this.cbAkcija.Name = "cbAkcija";
            this.cbAkcija.Size = new System.Drawing.Size(160, 24);
            this.cbAkcija.TabIndex = 0;
            // 
            // cbNekretnine
            // 
            this.cbNekretnine.FormattingEnabled = true;
            this.cbNekretnine.Location = new System.Drawing.Point(566, 144);
            this.cbNekretnine.Margin = new System.Windows.Forms.Padding(4);
            this.cbNekretnine.Name = "cbNekretnine";
            this.cbNekretnine.Size = new System.Drawing.Size(160, 24);
            this.cbNekretnine.TabIndex = 1;
            // 
            // cbResursi
            // 
            this.cbResursi.FormattingEnabled = true;
            this.cbResursi.Location = new System.Drawing.Point(312, 144);
            this.cbResursi.Margin = new System.Windows.Forms.Padding(4);
            this.cbResursi.Name = "cbResursi";
            this.cbResursi.Size = new System.Drawing.Size(160, 24);
            this.cbResursi.TabIndex = 2;
            // 
            // pnlBerza
            // 
            this.pnlBerza.Controls.Add(this.btnNekretnineIzvidi);
            this.pnlBerza.Controls.Add(this.btnResursiIzvidi);
            this.pnlBerza.Controls.Add(this.btnAkcijeVidi);
            this.pnlBerza.Controls.Add(this.btnBerza);
            this.pnlBerza.Controls.Add(this.btnNazad);
            this.pnlBerza.Controls.Add(this.cbResursi);
            this.pnlBerza.Controls.Add(this.cbNekretnine);
            this.pnlBerza.Controls.Add(this.cbAkcija);
            this.pnlBerza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBerza.Location = new System.Drawing.Point(0, 0);
            this.pnlBerza.Name = "pnlBerza";
            this.pnlBerza.Size = new System.Drawing.Size(781, 327);
            this.pnlBerza.TabIndex = 3;
            // 
            // btnNekretnineIzvidi
            // 
            this.btnNekretnineIzvidi.Location = new System.Drawing.Point(566, 100);
            this.btnNekretnineIzvidi.Name = "btnNekretnineIzvidi";
            this.btnNekretnineIzvidi.Size = new System.Drawing.Size(75, 23);
            this.btnNekretnineIzvidi.TabIndex = 7;
            this.btnNekretnineIzvidi.Text = "Izvidi";
            this.btnNekretnineIzvidi.UseVisualStyleBackColor = true;
            this.btnNekretnineIzvidi.Click += new System.EventHandler(this.btnNekretnineIzvidi_Click);
            // 
            // btnResursiIzvidi
            // 
            this.btnResursiIzvidi.Location = new System.Drawing.Point(312, 100);
            this.btnResursiIzvidi.Name = "btnResursiIzvidi";
            this.btnResursiIzvidi.Size = new System.Drawing.Size(75, 23);
            this.btnResursiIzvidi.TabIndex = 6;
            this.btnResursiIzvidi.Text = "Izvidi";
            this.btnResursiIzvidi.UseVisualStyleBackColor = true;
            this.btnResursiIzvidi.Click += new System.EventHandler(this.btnResursiIzvidi_Click);
            // 
            // btnAkcijeVidi
            // 
            this.btnAkcijeVidi.Location = new System.Drawing.Point(63, 100);
            this.btnAkcijeVidi.Name = "btnAkcijeVidi";
            this.btnAkcijeVidi.Size = new System.Drawing.Size(75, 23);
            this.btnAkcijeVidi.TabIndex = 5;
            this.btnAkcijeVidi.Text = "Izvidi";
            this.btnAkcijeVidi.UseVisualStyleBackColor = true;
            this.btnAkcijeVidi.Click += new System.EventHandler(this.btnVidi_Click);
            // 
            // btnBerza
            // 
            this.btnBerza.Location = new System.Drawing.Point(566, 277);
            this.btnBerza.Name = "btnBerza";
            this.btnBerza.Size = new System.Drawing.Size(75, 23);
            this.btnBerza.TabIndex = 4;
            this.btnBerza.Text = "Berza";
            this.btnBerza.UseVisualStyleBackColor = true;
            this.btnBerza.Click += new System.EventHandler(this.btnBerza_Click);
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(63, 277);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(75, 23);
            this.btnNazad.TabIndex = 3;
            this.btnNazad.Text = "Meni";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // frmOsoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 327);
            this.Controls.Add(this.pnlBerza);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmOsoba";
            this.Text = "Osoba";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmBerza_Paint);
            this.pnlBerza.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAkcija;
        private System.Windows.Forms.ComboBox cbNekretnine;
        private System.Windows.Forms.ComboBox cbResursi;
        private System.Windows.Forms.Panel pnlBerza;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnBerza;
        private System.Windows.Forms.Button btnAkcijeVidi;
        private System.Windows.Forms.Button btnNekretnineIzvidi;
        private System.Windows.Forms.Button btnResursiIzvidi;
    }
}