// See https://aka.ms/new-console-template for more information
using Primer04;

Console.WriteLine("Hello, World!");

// prikazivanje overrideovanje toString i equals metode

Osoba o1 = new Osoba
{
    Ime = "Ana",
    Prezime = "Anic"
};
Console.WriteLine(o1.ToString()); // poziva se override-ovana metoda ToString iz klase Osoba
//zakomentarisite override ToString u klasi Osoba i vidite razliku u ispisu

Osoba o2 = new Osoba
{
    Ime = "Ana",
    Prezime = "Anic"
};

if (o1.Equals(o2))
    Console.WriteLine("Osobe su jednake.");
else
    Console.WriteLine("Osobe nisu jednake.");

//zakomentarisite override Equals u klasi Osoba i vidite razliku u rezultatu poredjenja

