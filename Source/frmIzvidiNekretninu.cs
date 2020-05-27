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
    public partial class frmIzvidiNekretninu : Form
    {
        Nekretnine nekretnina = new Nekretnine();
        public frmIzvidiNekretninu(Nekretnine n)
        {
            InitializeComponent();
            nekretnina = n;
        }

        private void pnlNekretnina_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = pnlNekretnina.CreateGraphics();
            using (var brush = new LinearGradientBrush(DisplayRectangle, Color.Green, Color.DarkGray, LinearGradientMode.Vertical))
            {
                g.FillRectangle(brush, DisplayRectangle);
            }
            System.Drawing.Font font = new System.Drawing.Font("Arial", 20);
            g.DrawString("Tip nekretnine:", font, Brushes.Black, pnlNekretnina.Width / 20, 30);
            g.DrawString(nekretnina.TipSmestaja.ToString(), font, Brushes.Black, pnlNekretnina.Width / 20, 60);
            g.DrawString("Vrednost nekretnine:", font, Brushes.Black, pnlNekretnina.Width / 20, 100);
            g.DrawString(nekretnina.VrednostNekretnine.ToString() + "$", font, Brushes.Black, pnlNekretnina.Width / 20, 130);
            g.DrawString("Cena nekretnine:", font, Brushes.Black, pnlNekretnina.Width / 20, 170);
            g.DrawString(nekretnina.CenaClanarine.ToString(), font, Brushes.Black, pnlNekretnina.Width / 20, 200);

        }
    }
}
