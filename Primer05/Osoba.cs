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

        // u C#-u metode su po default-u obicne, a ne virtualne
        // da bi metoda mogla biti predefinisana u izvedenim klasama, mora biti deklarisana kao virtualna
        public virtual void NapisiZanimanje()
        {
            Console.WriteLine("Ja sam osoba.");
        }


    }
}
