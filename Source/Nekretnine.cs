using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatBerza
{
   public enum VrstaSmestaja
    {
        Stan,
        Kuca
    }
    public class Nekretnine
    {

        private double vrednostNekretnine;

        public double VrednostNekretnine
        {
            get { return vrednostNekretnine; }
            set { vrednostNekretnine = value; }
        }


        private VrstaSmestaja tipSmestaja;

        public VrstaSmestaja TipSmestaja
        {
            get { return tipSmestaja; }
            set { tipSmestaja = value; }
        }


        private double cenaClanarine;

        public double CenaClanarine
        {
            get { return cenaClanarine; }
            set { cenaClanarine = value; }
        }

        public Nekretnine(double vrednostNekretnine, VrstaSmestaja tipSmestaja, double cenaClanarine)
        {
            this.vrednostNekretnine = vrednostNekretnine;
            this.tipSmestaja = tipSmestaja;
            this.cenaClanarine = cenaClanarine;
        }
        public Nekretnine()
        {
            vrednostNekretnine = 1000;
            tipSmestaja = VrstaSmestaja.Kuca;
            cenaClanarine = 100;
        }
    }
}
