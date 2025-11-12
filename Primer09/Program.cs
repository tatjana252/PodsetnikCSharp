using System;
using System.Collections.Generic;
using System.Linq;

List<int> brojevi = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

// Filtriranje (Where)
var parni = brojevi.Where(b => b % 2 == 0);
Console.WriteLine("Parni brojevi: " + string.Join(", ", parni));


// Sortiranje (OrderBy, OrderByDescending)
var opadajuce = brojevi.OrderByDescending(b => b);
Console.WriteLine("Opadajuće: " + string.Join(", ", opadajuce));

// Agregacija (Sum, Average, Count)
Console.WriteLine($"Zbir: {brojevi.Sum()}");
Console.WriteLine($"Prosek: {brojevi.Average()}");
Console.WriteLine($"Broj elemenata: {brojevi.Count()}");

// Uzimanje i preskakanje (Take, Skip)
var prviTri = brojevi.Take(3);
var bezPrvaTri = brojevi.Skip(3);
Console.WriteLine("Prva tri: " + string.Join(", ", prviTri));
Console.WriteLine("Bez prva tri: " + string.Join(", ", bezPrvaTri));

// Provera postojanja (Any, All, Contains)
Console.WriteLine("Postoji broj veći od 8? " + brojevi.Any(b => b > 8));
Console.WriteLine("Svi su pozitivni? " + brojevi.All(b => b > 0));
Console.WriteLine("Sadrži broj 5? " + brojevi.Contains(5));

// Grupisanje (GroupBy)
var grupe = brojevi.GroupBy(b => b % 2 == 0 ? "Parni" : "Neparni");
foreach (var grupa in grupe)
    Console.WriteLine($"{grupa.Key}: {string.Join(", ", grupa)}");


