using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm k[sib kasutajal sisestada eesnime
            // programm kuvab kasutaja eesnime pikkuse

            Console.WriteLine("Siseda eesnimi:");
            string firstName = Console.ReadLine();

            int firstNameLengh = firstName.Length;
            Console.WriteLine($"Sinu eesnimes on {firstNameLengh} sümbolit");

            Console.Read();
        }
    }
}
