using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PraviProjekatBerza;

namespace ProjekatBerza
{
    public class Akcije
    {
        private string imeAkcije;

        public string ImeAkcije
        {
            get { return imeAkcije; }
            set { imeAkcije = value; }
        }


        private double vrednostAkcije;

        public double VrednostAkcije
        {
            get { return vrednostAkcije; }
            set { vrednostAkcije = value; }
        }


        private int broj;

        public int Broj
        {
            get { return broj; }
            set { broj = value; }
        }


        public Akcije(string imeAkcije, double vrednostAkcije, int broj)
        {
            this.imeAkcije = imeAkcije;
            this.vrednostAkcije = vrednostAkcije;
            this.broj = broj;
        }
        public Akcije()
        {
            imeAkcije = "ImeAkcije";
            vrednostAkcije = 100;
            broj = 10;
        }

    }
}
