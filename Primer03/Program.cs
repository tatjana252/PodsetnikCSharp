int broj = 10;
double realan = 3.14;
bool aktivan = true;
char karakter = 'A';

// var je ključna reč koja označava da će tip promenljive biti automatski određen na osnovu dodeljene vrednosti
// nakon inicijalizacije, tip promenljive ne može biti promenjen
var promenljiva = "Promenljiva";
// posto je tip odredjen na osnovu vrednosti, promenljiva je tipa string
// tako da mozemo koristiti string metode na njoj
Console.WriteLine(promenljiva.ToUpper());

// DateTime u C#-u je struktura
// strukture su korisnicki definisani vrednosni tipovi podataka
DateTime danas = DateTime.Now;
DateTime sutra = danas.AddDays(1);
DateTime dateTime = new DateTime(2024, 6, 1); // 1. jun 2024


// u c# postoje nullable vrednosni tipovi podataka
//nullable tipovi podataka su koristicni kada zelimo da predstavimo vrednost koja moze biti nepoznata ili odsutna
int? nullableBroj = null; 
nullableBroj = 5; 
Console.WriteLine("Broj: " + broj);

//stringovi su referentni tipovi podataka
string ime = "Marko";
string prezime = "Markovic";
string punoIme = ime + " " + prezime;


// u C#-u stringovi su nepromenljivi (immutable)
// oni se cuvaju u string pool-u radi optimizacije memorije
// sto znaci da se dva identicna stringa cuvaju na istom mestu u memoriji
//pa se mogu porediti pomocu == operatora
if (ime == "Marko")
{
    Console.WriteLine("Ime je Marko");
}
else
{
    Console.WriteLine("Ime nije Marko");
}


//osnovne metode stringa su

// pretvara string u velika slova
string s = ime.ToUpper();

// pretvara string u mala slova
s = ime.ToLower();

// vraca duzinu stringa
int duzina = ime.Length;

// deli string na niz stringova na osnovu razmaka
string[] tokeni = punoIme.Split(' ');

//kroz string se moze iterirati kao kroz niz karaktera
//ali string se ne moze menjati karakter po karakteru jer je nepromenljiv

for (int i = 0; i < ime.Length; i++)
{
    Console.WriteLine(ime[i]);
}

// strig se moze prebaciti u niz karaktera to treba koristiti ToCharArray() metodu
string s1 = "Hello";
char[] karakteri = s1.ToCharArray(); 
karakteri[0] = 'Z'; 


string pozdrav = new string(karakteri); // kreira string od niza karaktera


//string interpolacija je dostupna od C# 6.0 verzije
// omogucava jednostavnije formatiranje stringova
string interpoliraniString = $"Puno ime je: {punoIme}, a duzina imena je: {ime.Length}";
Console.WriteLine(interpoliraniString);



//osnovne kolekcije u C#-u su nizovi (arrays) i liste (lists)
int[] nizBrojeva = new int[5]; 
nizBrojeva[0] = 10; 
nizBrojeva[1] = 20;
nizBrojeva[2] = 30;
Console.WriteLine("Prvi element niza: " + nizBrojeva[0]);
Console.WriteLine("Duzina niza: " + nizBrojeva.Length); 

//iteracija kroz niz
for (int i = 0; i < nizBrojeva.Length; i++)
{
    Console.WriteLine("Element na indeksu " + i + ": " + nizBrojeva[i]);
}
//foreach petlja za iteraciju kroz niz
foreach (int brojUNizu in nizBrojeva)
{
    Console.WriteLine("Broj u nizu: " + brojUNizu);
}

// liste su dinamicne kolekcije koje mogu menjati velicinu
List<string> listaImena = new List<string>();
// List je genericka ArrayList koja moze da cuva elemente specificnog tipa podataka
listaImena.Add("Ana"); 
listaImena.Add("Marko");
listaImena.Add("Jelena");
Console.WriteLine("Prvo ime u listi: " + listaImena[0]);
Console.WriteLine("Duzina liste: " + listaImena.Count); // vraca broj elemenata u listi

//iteracija kroz listu
foreach (string imeUListi in listaImena)
{
    Console.WriteLine("Ime u listi: " + imeUListi);
}

// uklanjanje elementa iz liste
listaImena.Remove("Marko");


// provera da li lista sadrzi odredjeni element
bool sadrziAna = listaImena.Contains("Ana");
Console.WriteLine("Lista sadrzi Ana: " + sadrziAna);

// brisanje svih elemenata iz liste
listaImena.Clear();

//PARSIRANJE I KONVERZIJA TIPOVA PODATAKA

//parsiranje stringova u osnovne tipove podataka
string brojString = "123";
int parsedBroj = int.Parse(brojString); // parsiranje stringa u int
double parsedRealni = double.Parse("3.14"); // parsiranje stringa u double
bool parsedBool = bool.Parse("true"); // parsiranje stringa u bool
Console.WriteLine("Parsirani broj: " + parsedBroj);
Console.WriteLine("Parsirani realni broj: " + parsedRealni);
Console.WriteLine("Parsirani bool: " + parsedBool);
// ukoliko string nije validan za parsiranje, metode Parse bacaju izuzetak
try
{
    double greskaPriParsirnju = double.Parse("3.14as");
}
catch(FormatException ex) // hvatanje izuzetka FormatException
{
    Console.WriteLine("Greska pri parsiranju: " + ex.Message);
}
catch (Exception ex) // hvatanje svih ostalih izuzetaka
{
    Console.WriteLine("Opsta greska: " + ex.Message);
}

//ili moze i ovako
//try parse metoda koja ne baca izuzetak ako parsiranje ne uspeva
string losBrojString = "abc";
bool uspesnoParsirano = int.TryParse(losBrojString, out int rezultatParsiranja);
if (uspesnoParsirano)
{
    Console.WriteLine("Uspesno parsiran broj: " + rezultatParsiranja);
}
else
{
    Console.WriteLine("Neuspesno parsiranje broja iz stringa: " + losBrojString);
}


// konverzija osnovnih tipova podataka u string
int brojZaKonverziju = 456;
string brojKaoString = brojZaKonverziju.ToString(); // konverzija int u string

// parsiranje stringa u DateTime
// moze i samo datum ili samo vreme
string datumVremeString = "1.6.2024. 12:15";
DateTime parsedDatumVreme = DateTime.ParseExact(datumVremeString, "d.M.yyyy. H:mm", null);
Console.WriteLine("Parsirani datum i vreme: " + parsedDatumVreme.ToString());

// formatiranje DateTime u string
string formatiraniDatum = parsedDatumVreme.ToString("dd.MM.yyyy HH:mm");
Console.WriteLine("Formatirani datum i vreme: " + formatiraniDatum);