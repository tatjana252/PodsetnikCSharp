using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer04
{
    //u c#-u nasledjivanje, kao i implementacija interfejsa se vrsi pomocu (:) simbola
    //kada klasa nasledjuje drugu klasu, ona automatski dobija sva javna i zaštićena (protected) svojstva i metode bazne klase
    // moze dodavati svoja svojstva i metode, kao i predefinisati (override) metode bazne klase koje su deklarisane kao virtualne
    // jedna klasa moze nasledjivati samo jednu baznu klasu (C# ne podrzava vise nasledjivanje klasa)
    public class Student : Osoba
    {
        public string BrojIndeksa { get; set; }
        public Student() { }
        public override void NapisiZanimanje()
        {
            Console.WriteLine("Ja sam student, moj broj indeksa je: " + BrojIndeksa);
        }
    }


    public class Profesor : Osoba
    {
        public string SifraProfesora { get; set; }
        public Profesor() { }

        public override void NapisiZanimanje()
        {
            Console.WriteLine("Ja sam profesor, moja sifra je: " + SifraProfesora);
        }

        //obicna metoda iz bazne klase ne moze biti predefinisana u izvedenoj klasi
        //moze samo biti sakrivena pomocu new kljucne reci
        public new void Pozdravi()
        {
            Console.WriteLine("Zdravo, ja sam profesor " + PunoIme);
        }
    }
}
