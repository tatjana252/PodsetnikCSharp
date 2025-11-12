using System;
using System.Collections.Generic;
using System.Linq;


List<Student> studenti = new List<Student>
        {
            new Student { Ime = "Ana", Godine = 22, Prosek = 9.4, Grad = "Beograd" },
            new Student { Ime = "Marko", Godine = 21, Prosek = 8.2, Grad = "Novi Sad" },
            new Student { Ime = "Jelena", Godine = 23, Prosek = 9.8, Grad = "Beograd" },
            new Student { Ime = "Nikola", Godine = 20, Prosek = 7.5, Grad = "Nis" }
        };

// Filtriranje (Where)
var izBeograda = studenti.Where(s => s.Grad == "Beograd");
Console.WriteLine("Studenti iz Beograda:");
foreach (var s in izBeograda)
    Console.WriteLine(s.Ime);

// Sortiranje (OrderByDescending)
var poProseku = studenti.OrderByDescending(s => s.Prosek);
Console.WriteLine("\nSortirani po proseku:");
foreach (var s in poProseku)
    Console.WriteLine($"{s.Ime} ({s.Prosek})");

// Projekcija (Select)
var imena = studenti.Select(s => s.Ime);
Console.WriteLine("\nSamo imena: " + string.Join(", ", imena));

// Grupisanje (GroupBy)
var grupePoGradu = studenti.GroupBy(s => s.Grad);
Console.WriteLine("\nGrupisano po gradu:");
foreach (var grupa in grupePoGradu)
{
    string grad = grupa.Key;
    Console.WriteLine($"Grad: {grad}");
    foreach (var s in grupa)
        Console.WriteLine($" - {s.Ime}");
}

// Agregacija
double prosecnaOcena = studenti.Average(s => s.Prosek);
Console.WriteLine($"\nProsečan prosek svih studenata: {prosecnaOcena:F2}");

// Provera uslova
bool sviIznad8 = studenti.All(s => s.Prosek > 8);
Console.WriteLine("Svi studenti imaju prosek > 8? " + sviIznad8);

// Uzimanje najboljeg (First)
var najbolji = studenti.First(s => s.Prosek == studenti.Max(x => x.Prosek));
Console.WriteLine($"\nNajbolji student: {najbolji.Ime} ({najbolji.Prosek})");

// Single
var jedinstveniStudent = studenti.Single(s => s.Ime == "Marko"); // baciće izuzetak ako nema ili ima više od jednog studenta sa imenom "Marko"
Console.WriteLine($"\nJedinstveni student: {jedinstveniStudent.Ime} ({jedinstveniStudent.Prosek})");