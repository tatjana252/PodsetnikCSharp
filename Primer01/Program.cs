using System;

namespace Primer01 // namespace se koristi za logicku organizaciju koda, omogucava i grupisanje povezanih klasa i funkcija zajedno i izbegavanje konflikata imena.
{
    //modifikatori pristupa su: public, private, protected, internal, protected internal, private protected
    // internal - pristup je dozvoljen samo unutar istog skupa (assembly)
    //assembly je kompajlirani kod (npr .exe ili .dll fajl)
    // jedan assembly moze sadrzati vise namespace-ova
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console je klasa koja pripada System namespace-u i koristi se za ulazno-izlazne operacije u konzolnim aplikacijama
            // WriteLine je metoda klase Console koja ispisuje tekst na konzolu i prelazi u novi red
            // najznacajnije metode su Write i WriteLine, ReadLine.
            Console.WriteLine("Unesite vase ime: ");
            string unetoIme = Console.ReadLine(); // ceka da korisnik unese nesto i pritisne Enter
            Console.WriteLine("Hello " + unetoIme);
        }
    }
}
