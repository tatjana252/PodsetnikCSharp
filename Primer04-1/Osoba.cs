using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer04
{
    public class Osoba
    {

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string PunoIme
        {
            get { return Ime + " " + Prezime; }
        }
        public void Pozdravi()
        {
            Console.WriteLine("Zdravo, ja sam " + PunoIme);
        }

        public override string ToString()
        {
            return PunoIme;
        }
        // Override metode Equals za poređenje objekata Osoba
        public override bool Equals(object obj)
        {
            if (obj is Osoba o)
            {
                return this.Ime == o.Ime && this.Prezime == o.Prezime;
            }
            return false;

        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
