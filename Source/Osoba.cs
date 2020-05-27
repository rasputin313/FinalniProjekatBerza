using PraviProjekatBerza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatBerza
{
    public class Osoba
    {
        private string ime;

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        private double novac;


        public double Novac
        {
            get { return novac; }
            set { novac = value; }
        }


        private List<Akcije> listaAkcija = new List<Akcije>();

        public List<Akcije> ListaAkcija
        {
            get { return listaAkcija; }
            set { listaAkcija = value; }
        }
       // List<int> brojAkcija = new List<int>();

        private List<Nekretnine> listaNekretnina = new List<Nekretnine>();

        public List<Nekretnine> ListaNekretnina
        {
            get { return listaNekretnina; }
            set { listaNekretnina = value; }
        }


        //List<int> brojNekretnina = new List<int>();

        List<Resursi> listaResursa = new List<Resursi>();

        public List<Resursi> ListaResursa
        {
            get { return listaResursa; }
            set { listaResursa = value; }
        }



        //List<int> brojGrama = new List<int>();

        /* void kupiAkciju(Berza berza)
         {
             string imeAkcije = "";
             int brAkcija = 0;
             for(int i = 0;i < listaAkcija.Count;i++)
             {
                 if(listaAkcija[i].ImeAkcije == imeAkcije)
                 {
                     if(brAkcija <= brojAkcija[i])
                     {
                         brojAkcija[i] = brojAkcija[i] - brAkcija;
                         if(brojAkcija[i] == 0)
                         {
                             listaAkcija.RemoveAt(i);
                             //berza.ObrisiAkciju(imeAkcije, )//ovo mora da se menjaaaaaaaaaa
                             MessageBox.Show("Prodate su sve te akcije Vasom kupovinom.");
                         }
                     }
                     else
                     {
                         MessageBox.Show("Nema toliko akcija na berzi. Sledeci put unesite validan broj.");
                     }
                 }
                 else
                 {
                     MessageBox.Show("Ne postoji akcija u listi");
                 }
             }

         }*/

    }
}
