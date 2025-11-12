using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer06
{
    public partial class Student
    {
        public double Prosek { get; set; }

        public void PrikaziProsek()
        {
            Console.WriteLine($"Prosek: {Prosek}");
        }
    }
}
