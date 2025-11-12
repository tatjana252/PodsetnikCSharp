using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer08
{
    // delegat je tip koji predstavlja referencu na metodu sa specificiranim potpisom
    // delegati se koriste za implementaciju callback funkcija i za definisanje dogadjaja
    // ovde definisemo delegat koji predstavlja metodu koja prima dva cela broja i ne vraca povratnu vrednost
    delegate void Operacija(int a, int b);
}
