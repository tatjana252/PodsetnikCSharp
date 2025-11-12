//top-level statements su omogucene od C# 9.0 verzije
// omogucavaju pisanje jednostavnijih programa bez potrebe za definisanjem klase i Main metode
// u pozadini kompajler automatski kreira klasu i Main metodu
// u projektu moze da postoji samo jedan fajl sa top-level statements
using System; //ne moramo da ukljucujemo System jer je ukljucen po default-u u konzolnim aplikacijama
Console.WriteLine("Unesite vase ime: ");
string unetoIme = Console.ReadLine(); 
Console.WriteLine("Hello " + unetoIme);