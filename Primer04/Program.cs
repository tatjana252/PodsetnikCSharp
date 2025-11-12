//u ovom projektu bice predstavljene klase
// u C#-u korisnicki definisani tipovi podataka se kreiraju pomocu klasa i struktura
// klase su referentni tipovi podataka, a strukture su vrednosni tipovi podataka
// glavna razlika izmedju klasa i struktura je u nacinu na koji se cuvaju u memoriji
// klase se cuvaju u heap memoriji, dok se strukture cuvaju u stack memoriji
// klase se porede po referenci, dok se strukture porede po vrednosti

using System;
using Primer04; // ukljucujemo Primer04 namespace da bismo koristili Osoba klasu

//P1:
// kreiramo objekat klase Osoba koristeci parametrizovan konstruktor
// pozivamo metodu Pozdravi
// na kraju pristupamo svojstvu PunoIme
Osoba o1 = new Osoba("Pera", "Peric"); 
o1.Pozdravi(); 
Console.WriteLine("Puno ime osobe je: " + o1.PunoIme);

//P2:
// kreiramo objekat klase Osoba koristeci neparametrizovan konstruktor
// postavljamo vrednost svojstava Ime i Prezime
Osoba o2 = new Osoba(); 
o2.Ime = "Mika"; 
o2.Prezime = "Mikic"; 
o2.Pozdravi(); 
Console.WriteLine("Puno ime osobe je: " + o2.PunoIme); 
                                                       

// mozemo koristiti i inicijalizator objekta za postavljanje svojstava prilikom kreiranja objekta
Osoba o3 = new Osoba
{
    Ime = "Zika",
    Prezime = "Zikic"
};
o3.Pozdravi();
Console.WriteLine("Puno ime osobe je: " + o3.PunoIme);
