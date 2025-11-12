// See https://aka.ms/new-console-template for more information

using Primer08;
using System;

// prilikom inicializacije delegata, navodimo metodu koja odgovara potpisu delegata
Operacija operacije = Kalkulator.Saberi;
Console.WriteLine("#####");
operacije(10, 5); // pozivamo metodu preko delegata
Console.WriteLine("#####");

// jedan delegat moze da referencira vise metoda
//one ce se pozvati redom kako su dodate
operacije += Kalkulator.Oduzmi;
Console.WriteLine("#####");
operacije(10, 5);
Console.WriteLine("#####");
//takodje mozemo ukloniti metodu iz liste poziva
operacije -= Kalkulator.Saberi;
Console.WriteLine("#####");
operacije(10, 5);
Console.WriteLine("#####");

// danas se cesce koriste ugrađeni generički delegati Func, Action i Predicate
// Func - delegat koji vraća vrednost
// Action - delegat koji ne vraća vrednost (void)
// Predicate - delegat koji vraća bool vrednost

// Action koji prihvata dva cela broja
Action<int, int> actionOperacije = Kalkulator.Saberi;
Console.WriteLine("#####");
actionOperacije(20, 10);
Console.WriteLine("#####");

// takodje u C#-u mozemo koristiti lambda izraze za kreiranje anonimnih metoda
//struktura lambda izraza je:
// (parametri) => izraz ili blok koda

Action<int, int> lambdaOperacija = (a, b) =>
{
    int rezultat = a * b;
    Console.WriteLine($"Rezultat mnozenja: {rezultat}");
};

lambdaOperacija(4, 5);

// Func koji prihvata dva cela broja i vraca njihov količnik
Func<int, int, double> funcOperacija = (a,b) =>
{
    if (b == 0)
    {
        Console.WriteLine("Deljenje nulom nije dozvoljeno.");
        return 0;
    }
    return (double)a / b;
};

double kolicnik = funcOperacija(20, 4);

