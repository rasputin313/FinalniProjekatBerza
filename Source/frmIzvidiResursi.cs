using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjekatBerza;
using System.Drawing.Drawing2D;


namespace PraviProjekatBerza
{
    public partial class frmResurs : Form
    {
        Resursi resurs = new Resursi();
        public frmResurs(Resursi r)
        {
            InitializeComponent();
            resurs = r;
        }

        private void pnlResurs_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = pnlResurs.CreateGraphics();
            using (var brush = new LinearGradientBrush(DisplayRectangle, Color.Green, Color.DarkGray, LinearGradientMode.Vertical))
            {
                g.FillRectangle(brush, DisplayRectangle);
            }
            System.Drawing.Font font = new System.Drawing.Font("Arial", 20);
           g.DrawString("Tip resursa", font, Brushes.Black, pnlResurs.Width / 20, 30);
            g.DrawString(resurs.TipResursa.ToString(), font, Brushes.Black, pnlResurs.Width / 20, 60);
            g.DrawString("Vrednost resurs:", font, Brushes.Black, pnlResurs.Width / 20, 100);
            g.DrawString(resurs.VrednostResursa.ToString() + "$", font, Brushes.Black, pnlResurs.Width / 20, 130);
            g.DrawString("Broj grama:", font, Brushes.Black, pnlResurs.Width / 20, 170);
            g.DrawString(resurs.Broj.ToString(), font, Brushes.Black, pnlResurs.Width / 20, 200);

        }
    }
}
