using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatBerza
{
    public enum VrstaResursa
    {
        Zlato,
        Nafta,
        Dijamanti
    }
    public class Resursi
    {

        private double vrednostGrama;

        public double VrednostResursa
        {
            get { return vrednostGrama; }
            set { vrednostGrama = value; }
        }


        private VrstaResursa tipResursa;

        public VrstaResursa TipResursa
        {
            get { return tipResursa; }
            set { tipResursa = value; }
        }


        private int broj;

        public int Broj
        {
            get { return broj; }
            set { broj = value; }
        }

        public Resursi( double vrednostResursa, VrstaResursa tipResursa, int broj)
        {
            this.vrednostGrama = vrednostResursa;
            this.tipResursa = tipResursa;
            this.broj = broj;
        }
        public Resursi()
        {
            vrednostGrama = 10;
            tipResursa = VrstaResursa.Zlato;
            broj = 100;
        }
    }
}
