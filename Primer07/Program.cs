// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// --- Osnovna upotreba ---
DanUNedelji dan = DanUNedelji.Sreda;
Console.WriteLine($"Dan: {dan}");           // Ispisuje: Sreda
Console.WriteLine((int)dan);               // Ispisuje: 3

// --- Pretvaranje int u enum ---
int broj = 5;
DanUNedelji izBroja = (DanUNedelji)broj;
Console.WriteLine($"Iz broja {broj} → {izBroja}"); // Petak

// --- Pretvaranje string u enum (koristeći Enum.Parse) ---
string unos = "Subota";
try
{
    DanUNedelji izStringa = Enum.Parse<DanUNedelji>(unos);
    DanUNedelji izStringaCaseInsensitive = Enum.Parse<DanUNedelji>("sUboTa", true); // case-insensitive
    Console.WriteLine($"Iz stringa \"{unos}\" → {izStringa}");
    Console.WriteLine($"Iz stringa \"{unos}\" → {izStringaCaseInsensitive}");
}
catch (ArgumentException)
{
    Console.WriteLine($"Nevažeći unos za DanUNedelji: \"{unos}\"");
}

// --- Pretvaranje enum → string ---
string naziv = dan.ToString();
Console.WriteLine($"Enum u string: {naziv}");

// --- Provera da li je vrednost validna ---
int nepoznat = 10;
if (Enum.IsDefined(typeof(DanUNedelji), nepoznat))
    Console.WriteLine("Postoji dan sa tim brojem.");
else
    Console.WriteLine("Nepoznata vrednost za dan u nedelji.");