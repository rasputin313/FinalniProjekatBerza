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
using ProjekatBerza;


namespace PraviProjekatBerza
{
    public partial class frmBerza : Form
    {
        Berza berza = new Berza();
        Osoba osoba = new Osoba();
        public frmBerza(Berza b, Osoba o)
        {
            InitializeComponent();
            berza = b;
            osoba = o;

            cbAkcija.DataSource = berza.ListaAkcija;
            cbAkcija.DisplayMember = "ImeAkcije";
            cbTAkcija.DataSource = osoba.ListaAkcija;
            cbTAkcija.DisplayMember = "ImeAkcije";

            cbResursi.DataSource = berza.ListaResursa;
            cbResursi.DisplayMember = "TipResursa";
            cbTResursi.DataSource = osoba.ListaResursa;
            cbTResursi.DisplayMember = "TipResursa";

            cbNekretnine.DataSource = berza.ListaNekretnina;
            cbNekretnine.DisplayMember = "TipSmestaja";
            cbTNekretnine.DataSource = osoba.ListaNekretnina;
            cbTNekretnine.DisplayMember = "TipSmestaja";
        }

        private void pnlBerza_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = pnlBerza.CreateGraphics();
            using (var brush = new LinearGradientBrush(DisplayRectangle, Color.Green, Color.DarkGray, LinearGradientMode.Vertical))
            {
                g.FillRectangle(brush, DisplayRectangle);
            }

            g.DrawLine(new Pen(Color.Black), pnlBerza.Width / 3, 60, pnlBerza.Width / 3, pnlBerza.Height - 60);
            g.DrawLine(new Pen(Color.Black), pnlBerza.Width / 3, 60, pnlBerza.Width / 3, pnlBerza.Height - 60);
            g.DrawLine(new Pen(Color.Black), pnlBerza.Width / 3 * 2, 60, pnlBerza.Width / 3 * 2, pnlBerza.Height - 60);
            g.DrawLine(new Pen(Color.Black), 10, 90, pnlBerza.Width - 10, 90);
            float[] dashValues = { 5, 2 };
            Pen blackPen = new Pen(Color.Black, 1);
            blackPen.DashPattern = dashValues;
            g.DrawLine(blackPen, 101, 120, 101, 267);//kako ovo nije kao cb na x osi od 136 nista nema smisla
            g.DrawLine(blackPen, 301, 120, 301, 267);//zasto razmak izmedju linija nije kao izmedju cb-ova
            g.DrawLine(blackPen, 502, 120, 502, 267);

            System.Drawing.Font font = new System.Drawing.Font("Arial", 30);
            g.DrawString("Berza", font, Brushes.Black,pnlBerza.Width/2 - 60 , 10);

            System.Drawing.Font font2 = new System.Drawing.Font("Arial", 15);
            g.DrawString("Akcije", font2, Brushes.Black, pnlBerza.Width / 6 - 25, 70);
            g.DrawString("Resursi", font2, Brushes.Black, pnlBerza.Width / 2 - 35, 70);
            g.DrawString("Nekretnine", font2, Brushes.Black, pnlBerza.Width / 6 * 5 - 50, 70);

            System.Drawing.Font font3 = new System.Drawing.Font("Arial", 10);
            g.DrawString("Berza", font3, Brushes.Black, pnlBerza.Width / 6 - 65, 95);
            g.DrawString("Vi", font3, Brushes.Black, pnlBerza.Width / 6 + 40, 95);
            g.DrawString("Berza", font3, Brushes.Black, pnlBerza.Width / 6 + 145, 95);
            g.DrawString("Vi", font3, Brushes.Black, pnlBerza.Width / 6 + 245, 95);
            g.DrawString("Berza", font3, Brushes.Black, pnlBerza.Width / 6 + 345, 95);
            g.DrawString("Vi", font3, Brushes.Black, pnlBerza.Width / 6 + 445, 95);
        }

        private void btnAkcijaIzvidi_Click(object sender, EventArgs e)
        {
            string selected = this.cbAkcija.GetItemText(this.cbAkcija.SelectedItem);
            if(this.cbAkcija.SelectedItem != null)
            {
                Akcije a = new Akcije();
                foreach (Akcije akcija in berza.ListaAkcija)
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

        private void btnIzvidiTAkciju_Click(object sender, EventArgs e)
        {
            string selected = this.cbTAkcija.GetItemText(this.cbTAkcija.SelectedItem);
            if (this.cbTAkcija.SelectedItem != null)
            {
                Akcije a = new Akcije();
                foreach (Akcije akcija in osoba.ListaAkcija)
                {
                    if (akcija.ImeAkcije == selected)
                        a = akcija;
                }
                frmIzvidiAkciju frmIzvidiAkciju = new frmIzvidiAkciju(a);
                cbTAkcija.SelectedIndex = -1;

                if (frmIzvidiAkciju.ShowDialog() != DialogResult.OK)
                    return;
            }
            else
            {
                MessageBox.Show("Prazno");
            }
        }
        private void btnResursIzvidi_Click(object sender, EventArgs e)
        {
            string selected = this.cbResursi.GetItemText(this.cbResursi.SelectedItem);
            if(cbResursi.SelectedItem != null)
            {
                Resursi r = new Resursi();
                foreach (Resursi resurs in berza.ListaResursa)
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
        private void btnIzvidiTResursi_Click(object sender, EventArgs e)
        {
            string selected = this.cbTResursi.GetItemText(this.cbTResursi.SelectedItem);
            if (cbTResursi.SelectedItem != null)
            {
                Resursi r = new Resursi();
                foreach (Resursi resurs in osoba.ListaResursa)
                {
                    if (resurs.TipResursa.ToString() == selected)
                        r = resurs;
                }

                frmResurs frmResurs = new frmResurs(r);
                cbTResursi.SelectedIndex = -1;

                if (frmResurs.ShowDialog() != DialogResult.OK)
                    return;
            }
            else
            {
                MessageBox.Show("Prazno");
            }
        }
        private void btnIzvidiResurs_Click(object sender, EventArgs e)//treba izvidiNekretnine promenio sam sada ime ali kasno a da ne idem u onj designer
        {
            string selected = this.cbNekretnine.GetItemText(this.cbNekretnine.SelectedItem);
            if(cbNekretnine.SelectedItem != null)
            {
                Nekretnine n = new Nekretnine();
                foreach (Nekretnine nekretnina in berza.ListaNekretnina)
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
        private void btnIzvidiTNekretninu_Click(object sender, EventArgs e)
        {
            string selected = this.cbTNekretnine.GetItemText(this.cbTNekretnine.SelectedItem);
            if (cbTNekretnine.SelectedItem != null)
            {
                Nekretnine n = new Nekretnine();
                foreach (Nekretnine nekretnina in osoba.ListaNekretnina)
                {
                    if (nekretnina.TipSmestaja.ToString() == selected)
                        n = nekretnina;
                }

                frmIzvidiNekretninu frmNekretnina = new frmIzvidiNekretninu(n);
                cbTNekretnine.SelectedIndex = -1;

                if (frmNekretnina.ShowDialog() != DialogResult.OK)
                    return;
            }
            else
            {
                MessageBox.Show("Prazno");
            }
        }

        private void btnOsoba_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKupiAkciju_Click(object sender, EventArgs e)
        {
            string selected = this.cbAkcija.GetItemText(this.cbAkcija.SelectedItem);
            for(int i = 0;i < berza.ListaAkcija.Count; i++)
            {
                if(berza.ListaAkcija[i].ImeAkcije == selected)
                {
                   /*foreach(Akcije akcija in osoba.ListaAkcija)
                    {
                        if(osoba.ListaAkcija[i].ImeAkcije == selected)
                        {
                            if((osoba.ListaAkcija[i].VrednostAkcije * osoba.ListaAkcija[i].Broj) > berza.ListaAkcija[i].VrednostAkcije * osoba.ListaAkcija[i].Broj)
                            {*/
                                osoba.ListaAkcija.Add(berza.ListaAkcija[i]);
                                cbTAkcija.DataSource = null;
                                cbTAkcija.Items.Add(berza.ListaAkcija[i]);
                                berza.ListaAkcija.RemoveAt(i);
                                cbAkcija.DataSource = null;
                                cbAkcija.Items.Remove(this.cbAkcija.SelectedItem);

                                cbTAkcija.DataSource = osoba.ListaAkcija;
                                cbTAkcija.DisplayMember = "ImeAkcije";
                                cbAkcija.DataSource = berza.ListaAkcija;
                                cbAkcija.DisplayMember = "ImeAkcije";
                }
                            /*else
                            {
                                MessageBox.Show("Nemas kesa");
                            }
                        }
                    }

                }
               /* else
                {
                     MessageBox.Show("Nemas kesa");
                }*/
            }
        }

        private void btnKupiResurs_Click(object sender, EventArgs e)
        {
            string selected = this.cbResursi.GetItemText(this.cbResursi.SelectedItem);
            for (int i = 0; i < berza.ListaResursa.Count; i++)
            {
                if (berza.ListaResursa[i].TipResursa.ToString() == selected)
                {
                    osoba.ListaResursa.Add(berza.ListaResursa[i]);
                    cbTResursi.DataSource = null;
                    cbTResursi.Items.Add(berza.ListaResursa[i]);
                    berza.ListaResursa.RemoveAt(i);
                    cbResursi.DataSource = null;
                    cbResursi.Items.Remove(this.cbResursi.SelectedItem);

                    cbTResursi.DataSource = osoba.ListaResursa;
                    cbTResursi.DisplayMember = "TipResursa";
                    cbResursi.DataSource = berza.ListaResursa;
                    cbResursi.DisplayMember = "TipResursa";
                    //cbAkcija.
                }
            }
        }
    }
}
