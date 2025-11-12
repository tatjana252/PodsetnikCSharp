using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer06
{
    //klase u C#-u mogu biti deljene na vise fajlova pomocu partial kljucne reci
    // sve deljene klase moraju biti u istom namespace-u
    // ovo je korisno kada zelimo da organizujemo veliki kod u manje delove
    public partial class Student
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public void PrikaziOsnovnePodatke()
        {
            Console.WriteLine($"{Ime} {Prezime}");
        }
    }
}
