using ProjekatBerza;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace PraviProjekatBerza
{
    public partial class frmOsoba : Form
    {
        Osoba persona = new Osoba();
        Berza berza = new Berza();
        public frmOsoba(Osoba osoba, Berza b)
        {
            InitializeComponent();
            persona = osoba;
            berza = b;
            cbAkcija.DataSource = osoba.ListaAkcija;
            cbAkcija.DisplayMember = "ImeAkcije";
            cbResursi.DataSource = osoba.ListaResursa;
            cbResursi.DisplayMember = "TipResursa";
            cbNekretnine.DataSource = osoba.ListaNekretnina;
            cbNekretnine.DisplayMember = "TipSmestaja";
        }

        private void frmBerza_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = pnlBerza.CreateGraphics();
            using (var brush = new LinearGradientBrush(DisplayRectangle, Color.Green, Color.DarkGray, LinearGradientMode.Vertical))
            {
                g.FillRectangle(brush, DisplayRectangle);
            }
            System.Drawing.Font font = new System.Drawing.Font("Arial", 12);
            g.DrawString("Akcije:", font, Brushes.Black, 105, 84);
            g.DrawString("Resursi:", font, Brushes.Black, 290, 84);
            g.DrawString("Nekretnine:", font, Brushes.Black, 480, 84);
            g.DrawString("Pare:", font, Brushes.Black, 240, 225);
            g.DrawString(persona.Novac.ToString() + "$", font, Brushes.Black, 280, 225);
            System.Drawing.Font font2 = new System.Drawing.Font("Arial", 30);
            g.DrawString("Profil:", font2, Brushes.Black, pnlBerza.Width / 2 - 65, 10);
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBerza_Click(object sender, EventArgs e)
        {
            frmBerza frmBerza = new frmBerza(berza, persona);
            if (frmBerza.ShowDialog() != DialogResult.OK)
                return;


        }

        private void btnVidi_Click(object sender, EventArgs e)
        {
            string selected = this.cbAkcija.GetItemText(this.cbAkcija.SelectedItem);
            if(cbAkcija.SelectedItem != null)
            {
                Akcije a = new Akcije();
                foreach (Akcije akcija in persona.ListaAkcija)
                {
                    if (akcija.ImeAkcije == selected)
                        a = akcija;
                }
                frmIzvidiAkciju frmIzvidiAkciju = new frmIzvidiAkciju(a);
                cbAkcija.SelectedIndex = -1;

                if (frmIzvidiAkciju.ShowDialog() != DialogResult.OK)
                    return;
            }
            else
            {
                MessageBox.Show("Prazno");
            }
        }

        private void btnResursiIzvidi_Click(object sender, EventArgs e)
        {

            string selected = this.cbResursi.GetItemText(this.cbResursi.SelectedItem);
            if(cbResursi.SelectedItem != null)
            {
                Resursi r = new Resursi();
                foreach (Resursi resurs in persona.ListaResursa)
                {
                    if (resurs.TipResursa.ToString() == selected)
                        r = resurs;
                }

                frmResurs frmResurs = new frmResurs(r);
                cbResursi.SelectedIndex = -1;

                if (frmResurs.ShowDialog() != DialogResult.OK)
                    return;
            }
            else
            {
                MessageBox.Show("Prazno");
            }
        }

        private void btnNekretnineIzvidi_Click(object sender, EventArgs e)
        {
            string selected = this.cbNekretnine.GetItemText(this.cbNekretnine.SelectedItem);
            if(cbNekretnine.SelectedItem != null)
            {
                Nekretnine n = new Nekretnine();
                foreach (Nekretnine nekretnina in persona.ListaNekretnina)
                {
                    if (nekretnina.TipSmestaja.ToString() == selected)
                        n = nekretnina;
                }

                frmIzvidiNekretninu frmNekretnina = new frmIzvidiNekretninu(n);
                cbNekretnine.SelectedIndex = -1;

                if (frmNekretnina.ShowDialog() != DialogResult.OK)
                    return;
            }
            else
            {
                MessageBox.Show("Prazno");
            }
        }
    }
}
