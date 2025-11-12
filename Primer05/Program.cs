// See https://aka.ms/new-console-template for more information
using Primer04;

Console.WriteLine("Hello, World!");

Osoba o1 = new Osoba
{
    Ime = "Ana",
    Prezime = "Anic"
};
o1.Pozdravi();
o1.NapisiZanimanje();

Student s1 = new Student
{
    Ime = "Marko",
    Prezime = "Markovic",
    BrojIndeksa = "2024001"
};
s1.Pozdravi();
s1.NapisiZanimanje();

Profesor p1 = new Profesor
{
    Ime = "Jovan",
    Prezime = "Jovanovic",
    SifraProfesora = "PROF123"
};
p1.Pozdravi(); // poziva se sakrivena metoda iz klase Profesor
p1.NapisiZanimanje();


Osoba o2 = s1; // implicitna konverzija iz Student u Osoba, 
o2.Pozdravi();
o2.NapisiZanimanje(); // poziva se predefinisana metoda iz klase Student, jer je virtualna

Osoba o3 = p1; // implicitna konverzija iz Profesor u Osoba
o3.Pozdravi(); // ovde se ne poziva skrivena metoda iz klase Profesor, vec metoda iz klase Osoba
o3.NapisiZanimanje(); // poziva se predefinisana metoda iz klase Profesor, jer je virtualna


//koriscenje is operatora za proveru tipa pre konverzije
if (o2 is Student)
{
    Student s2 = (Student)o2; // eksplicitna konverzija iz Osoba u Student
    Console.WriteLine("Broj indeksa studenta je: " + s2.BrojIndeksa);
}
//odmah proveravamo tip i vrsimo konverziju
if (o3 is Profesor profesor)
{
    Console.WriteLine("Sifra profesora je: " + profesor.SifraProfesora);
}

//koriscenje as operatora za bezbednu konverziju
// vraca null ako konverzija nije moguca
Student s3 = o2 as Student;
if(s3 != null)
{
    Console.WriteLine("Broj indeksa studenta je: " + s3.BrojIndeksa);
}
