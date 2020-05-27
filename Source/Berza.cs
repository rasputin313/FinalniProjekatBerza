using ProjekatBerza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraviProjekatBerza
{
    public class Berza
    {

        private List<Akcije> listaAkcija = new List<Akcije>();

        public List<Akcije> ListaAkcija
        {
            get { return listaAkcija; }
            set { listaAkcija = value; }
        }

       // private List<int> brojAkcija = new List<int>();

        private List<Nekretnine> listaNekretnina = new List<Nekretnine>();

        public List<Nekretnine> ListaNekretnina
        {
            get { return listaNekretnina; }
            set { listaNekretnina = value; }
        }
       // private List<int> brojNekretnina = new List<int>();

        private List<Resursi> listaResursa = new List<Resursi>();
        public List<Resursi> ListaResursa
        {
            get { return listaResursa; }
            set { listaResursa = value; }
        }


        //private List<int> brojGrama = new List<int>();


       /* void dodajAkciju(Akcije akcija, int broj)
        {
            for(int i = 0; i < listaAkcija.Count; i++)
            {
                if(listaAkcija[i] == akcija)
                {
                    brojAkcija[i] += broj;
                }
            }
            listaAkcija.Add(akcija);
            brojAkcija.Add(broj);
        }

        string obrisiAkcijuBroj(Akcije akcija, int broj)
        {
            string povratni = "Ne postoji";
            for (int i = 0; i < listaAkcija.Count; i++)
            {
                if (listaAkcija[i] == akcija)
                {
                    int temp = brojAkcija[i];
                    if(temp <= broj)
                    {
                        brojAkcija.RemoveAt(i);
                        povratni = "0" + (broj - temp).ToString();
                    }
                    else
                    {
                        brojAkcija[i] = temp - broj;
                        povratni = (temp - broj).ToString();
                    }

                }
            }
            return povratni;
        }

        void obrisiAkcijuAkcija(Akcije akcija, bool obrisi)
        {
            if(obrisi)
            {
                for (int i = 0; i < listaAkcija.Count; i++)
                {
                    if (listaAkcija[i] == akcija)
                    {
                        listaAkcija.Remove(akcija);
                    }
                }
            }
        }


        void dodajNekretninu(Nekretnine nekretnina, int broj)//u slucaju da je neki kompleks zgrada ili neki kao bungalovi
        {
            for (int i = 0; i < listaNekretnina.Count; i++)
            {
                if (listaNekretnina[i] == nekretnina)
                {
                    brojNekretnina[i] += broj;
                }
            }
            listaNekretnina.Add(nekretnina);
            brojNekretnina.Add(broj);
        }

        string obrisiNekretninuBroj(Nekretnine nekretnina, int broj)
        {
            string povratni = "Ne postoji";
            for (int i = 0; i < listaNekretnina.Count; i++)
            {
                if (listaNekretnina[i] == nekretnina)
                {
                    int temp = brojNekretnina[i];
                    if(temp <= broj)
                    {
                        brojNekretnina.RemoveAt(i);
                        povratni = "0" + (broj - temp).ToString();
                    }
                    else
                    {
                        brojNekretnina[i] = temp - broj;
                        povratni = (temp - broj).ToString();
                    }
                }
            }
            return povratni;
        }
        void obrisiNekretninuNekretnina(Nekretnine nekretnina, bool obrisi)
        {
            if (obrisi)
            {
                for (int i = 0; i < listaNekretnina.Count; i++)
                {
                    if (listaNekretnina[i] == nekretnina)
                    {
                        listaNekretnina.Remove(nekretnina);
                    }
                }
            }
        }


        void dodajResurs(Resursi resurs, int gramaza)
        {
            for (int i = 0; i < listaResursa.Count; i++)
            {
                if (listaResursa[i] == resurs)
                {
                    brojGrama[i] += gramaza;
                }
            }
            listaResursa.Add(resurs);
            brojGrama.Add(gramaza);
        }
        string obrisiResursBroj(Resursi resurs, int broj)
        {
            string povratni = "Ne postoji";
            for (int i = 0; i < listaResursa.Count; i++)
            {
                if (listaResursa[i] == resurs)
                {
                    int temp = brojGrama[i];
                    if (temp <= broj)
                    {
                        brojGrama.RemoveAt(i);
                        povratni = "0" + (broj - temp).ToString();
                    }
                    else
                    {
                        brojGrama[i] = temp - broj;
                        povratni = (temp - broj).ToString();
                    }
                }
            }
            return povratni;
        }
        void obrisiResursResurs(Resursi resurs, bool obrisi)
        {
            if (obrisi)
            {
                for (int i = 0; i < listaResursa.Count; i++)
                {
                    if (listaResursa[i] == resurs)
                    {
                        listaResursa.Remove(resurs);
                    }
                }
            }
        }*/
    }
}
