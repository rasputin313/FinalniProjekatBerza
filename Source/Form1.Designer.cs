namespace PraviProjekatBerza
{
    partial class frmMeni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMeni));
            this.frmMain = new System.Windows.Forms.Panel();
            this.btnShrek = new System.Windows.Forms.Button();
            this.btnNiceGuy = new System.Windows.Forms.Button();
            this.pbShrek = new System.Windows.Forms.PictureBox();
            this.pbNiceGuy = new System.Windows.Forms.PictureBox();
            this.frmMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShrek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNiceGuy)).BeginInit();
            this.SuspendLayout();
            // 
            // frmMain
            // 
            this.frmMain.Controls.Add(this.btnShrek);
            this.frmMain.Controls.Add(this.btnNiceGuy);
            this.frmMain.Controls.Add(this.pbShrek);
            this.frmMain.Controls.Add(this.pbNiceGuy);
            this.frmMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmMain.Location = new System.Drawing.Point(0, 0);
            this.frmMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.frmMain.Name = "frmMain";
            this.frmMain.Size = new System.Drawing.Size(512, 308);
            this.frmMain.TabIndex = 0;
            this.frmMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMeni_Paint);
            // 
            // btnShrek
            // 
            this.btnShrek.Location = new System.Drawing.Point(348, 238);
            this.btnShrek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShrek.Name = "btnShrek";
            this.btnShrek.Size = new System.Drawing.Size(100, 28);
            this.btnShrek.TabIndex = 3;
            this.btnShrek.Text = "Mačo Men";
            this.btnShrek.UseVisualStyleBackColor = true;
            this.btnShrek.Click += new System.EventHandler(this.btnShrek_Click);
            // 
            // btnNiceGuy
            // 
            this.btnNiceGuy.Location = new System.Drawing.Point(59, 238);
            this.btnNiceGuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNiceGuy.Name = "btnNiceGuy";
            this.btnNiceGuy.Size = new System.Drawing.Size(100, 28);
            this.btnNiceGuy.TabIndex = 2;
            this.btnNiceGuy.Text = "Tupan Tupson";
            this.btnNiceGuy.UseVisualStyleBackColor = true;
            this.btnNiceGuy.Click += new System.EventHandler(this.btnNiceGuy_Click);
            // 
            // pbShrek
            // 
            this.pbShrek.Image = ((System.Drawing.Image)(resources.GetObject("pbShrek.Image")));
            this.pbShrek.Location = new System.Drawing.Point(283, 62);
            this.pbShrek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbShrek.Name = "pbShrek";
            this.pbShrek.Size = new System.Drawing.Size(213, 169);
            this.pbShrek.TabIndex = 1;
            this.pbShrek.TabStop = false;
            // 
            // pbNiceGuy
            // 
            this.pbNiceGuy.Image = ((System.Drawing.Image)(resources.GetObject("pbNiceGuy.Image")));
            this.pbNiceGuy.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbNiceGuy.InitialImage")));
            this.pbNiceGuy.Location = new System.Drawing.Point(16, 62);
            this.pbNiceGuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbNiceGuy.Name = "pbNiceGuy";
            this.pbNiceGuy.Size = new System.Drawing.Size(212, 169);
            this.pbNiceGuy.TabIndex = 0;
            this.pbNiceGuy.TabStop = false;
            // 
            // frmMeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 308);
            this.Controls.Add(this.frmMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMeni";
            this.Text = "Meni";
            this.frmMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbShrek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNiceGuy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel frmMain;
        private System.Windows.Forms.PictureBox pbNiceGuy;
        private System.Windows.Forms.PictureBox pbShrek;
        private System.Windows.Forms.Button btnShrek;
        private System.Windows.Forms.Button btnNiceGuy;
    }
}

