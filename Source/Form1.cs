using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjekatBerza;
using System.Xml.Serialization;
using System.IO;

namespace PraviProjekatBerza
{
    public partial class frmMeni : Form
    {
        public frmMeni()
        {
            InitializeComponent();
            /*Stream stream = File.OpenWrite(Environment.CurrentDirectory + "\\Xml.xml");
            XmlSerializer mojXmlSer = new XmlSerializer(typeof(Osoba));
            mojXmlSer.Serialize(stream, Osoba);
            stream.Close();*/
        }


        private Osoba osoba = new Osoba();

        public Osoba Osoba

        {
            get { return osoba; }
            set { osoba = value; }
        }


        private Berza berza = new Berza();

        public Berza Berza
        {
            get { return berza; }
            set { berza = value; }
        }

        


        private void pnlMeni_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = frmMain.CreateGraphics();
            using (var brush = new LinearGradientBrush(DisplayRectangle, Color.Green, Color.DarkGray, LinearGradientMode.Vertical))
            {
                g.FillRectangle(brush, DisplayRectangle);
            }
            g.DrawLine(new Pen(Color.Black), frmMain.Width / 2, 50, frmMain.Width / 2, frmMain.Height);
            System.Drawing.Font font = new System.Drawing.Font("Arial", 20);
            g.DrawString("Choose your fighter:", font, Brushes.Black, 60, 10);
        }

        private void btnNiceGuy_Click(object sender, EventArgs e)
        {
            XmlSerializer mojXmlSer = new XmlSerializer(typeof(Osoba));
            StreamReader streamReader = new StreamReader(Environment.CurrentDirectory + "\\Xml.xml");
            osoba = (Osoba)mojXmlSer.Deserialize(streamReader);
            streamReader.Close();
            osoba.ListaAkcija.Clear();
            osoba.ListaNekretnina.Clear();
            osoba.ListaNekretnina.Clear();
            /*Akcije akcija = new Akcije("TSLA", 900, 40, 10);
            Akcije akcija2 = new Akcije("ABN", 300, 20, 10);
            Akcije akcija3 = new Akcije("Joca", 200, 30, 23);
            Resursi resurs = new Resursi(56, VrstaResursa.Zlato, 10);
            Nekretnine nekretnina = new Nekretnine(123000, VrstaSmestaja.Kuca, 500);
            osoba.ListaAkcija.Add(akcija);
            osoba.ListaAkcija.Add(akcija2);
            osoba.ListaResursa.Add(resurs);
            osoba.ListaNekretnina.Add(nekretnina);
            osoba.Novac = 14;

            berza.ListaAkcija.Add(akcija3);
            berza.ListaResursa.Add(resurs);
            berza.ListaNekretnina.Add(nekretnina);*/

            frmOsoba frmOsoba = new frmOsoba(osoba, berza);
            if (frmOsoba.ShowDialog() != DialogResult.OK)
                return;
        }

        private void btnShrek_Click(object sender, EventArgs e)
        {
            Akcije akcija = new Akcije("TSLA", 900, 10);
            Akcije akcija2 = new Akcije("ABN", 300, 10);
            Akcije akcija3 = new Akcije("Joca", 200, 23);
            Resursi resurs = new Resursi(56, VrstaResursa.Zlato, 10);
            Nekretnine nekretnina = new Nekretnine(123000, VrstaSmestaja.Kuca, 500);
            osoba.ListaAkcija.Add(akcija);
            osoba.ListaAkcija.Add(akcija2);
            osoba.ListaResursa.Add(resurs);
            osoba.ListaNekretnina.Add(nekretnina);
            osoba.Novac = 14;

            berza.ListaAkcija.Add(akcija3);
            berza.ListaResursa.Add(resurs);
            berza.ListaNekretnina.Add(nekretnina);
            frmOsoba frmOsoba = new frmOsoba(osoba, berza);
            if (frmOsoba.ShowDialog() != DialogResult.OK)
                return;
        }
    }
}
