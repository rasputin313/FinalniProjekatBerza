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
    public partial class frmIzvidiAkciju : Form
    {
        Akcije akcija = new Akcije();
        public frmIzvidiAkciju(Akcije a)
        {
            InitializeComponent();
            akcija = a;
        }

        private void pnlAkcija_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = pnlAkcija.CreateGraphics();
            using (var brush = new LinearGradientBrush(DisplayRectangle, Color.Green, Color.DarkGray, LinearGradientMode.Vertical))
            {
                g.FillRectangle(brush, DisplayRectangle);
            }
            System.Drawing.Font font = new System.Drawing.Font("Arial", 20);
            g.DrawString("Ime Akcije:", font, Brushes.Black, pnlAkcija.Width / 20 , 30);
            g.DrawString(akcija.ImeAkcije, font, Brushes.Black, pnlAkcija.Width / 20, 60);
            g.DrawString("Vrednost akcije:", font, Brushes.Black, pnlAkcija.Width / 20, 100);
            g.DrawString(akcija.VrednostAkcije.ToString() + "$", font, Brushes.Black, pnlAkcija.Width / 20, 130);
            g.DrawString("Broj akcija:", font, Brushes.Black, pnlAkcija.Width / 20, 170);
            g.DrawString(akcija.Broj.ToString(), font, Brushes.Black, pnlAkcija.Width / 20, 200);



            /*ccAkcije.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Poslednji ulaz:",
                Labels = new[] { "1", "2", "3", "4", "5" }
            });
            ccAkcije.AxisY.Add(new LiveCharts.Wpf.Axis 
            { 
                Title = "Cena",
                LabelFormatter = akcija.VrednostAkcije + "$"
            });*/
        }
    }
}
