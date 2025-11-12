using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer08
{
    //ukoliko klasa sadrzi samo staticke metode, moze biti deklarisana kao staticka klasa
    public static class Kalkulator
    {
        // i u C#-u postoje staticke metode koje pripadaju klasi, a ne instanci klase

        public static void Saberi(int a, int b)
        {
            Console.WriteLine("Zbir je: " + (a + b));
        }

        public static void Oduzmi(int a, int b)
        {
            Console.WriteLine("Razlika je: " + (a - b));
        }

    }
}
