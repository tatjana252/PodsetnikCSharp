using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer04
{
    public class Osoba
    {

        //klasa moze imate neparametrizovan i parametrizovane konstruktore
        public Osoba() { } // neparametrizovan konstruktor
        public Osoba(string ime, string prezime) // parametrizovan konstruktor
        {
            this.ime = ime; // dodeljivanje vrednosti polju ime
            this.prezime = prezime; // dodeljivanje vrednosti polju prezime
        }


        // polja su promenljive koje cuvaju podatke o objektu
        private string ime; // polje za ime osobe
        private string prezime; // polje za prezime osobe
        // svojstva omogucavaju kontrolisan pristup poljima, odnosno enkapsulaciju podataka
        // svojstva se sastoje iz get i set metoda
        public string Ime
        {
            get { return ime; } // get metoda vraca vrednost polja ime
            set { ime = value; } // value predstavlja vrednost koja se dodeljuje svojstvu
        }

        //svojstvo moze biti i auto-implementirano
        public string Prezime { get; set; } // ne vidimo atribut prezime, ali kompajler automatski kreira privatno polje za njega

        // svojstvo moze imati samo get ili samo set metodu
        public string PunoIme
        {
            get { return ime + " " + prezime; } // samo get metoda, vraca puno ime osobe
        }

        // metode su funkcije koje obavljaju operacije nad podacima objekta
        public void Pozdravi()
        {
            Console.WriteLine("Zdravo, ja sam " + PunoIme);
        }


    }
}
