using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm küsib kasutajalt sisestada ees- ja perekonnanime
            // programm kontrollib andmete pikkust
            // programm kuvab kumb nendes on pikem, kas ees või perekonnanimi

            Console.WriteLine("Sisesta eesnimi");
            string firstName = Console.ReadLine();
            int firstNamelenght = firstName.Length;

            Console.WriteLine("Sisesta perekonnanimi");
            string lastName = Console.ReadLine();
            int lastNamelenght = lastName.Length;

            if (firstNamelenght > lastNamelenght)
            {
                Console.WriteLine($"Sinu eesnimes on {firstNamelenght} sümbolit");
            }
            if (lastNamelenght > firstNamelenght)
            {
                Console.WriteLine($"Sinu perekonnanimes on {lastNamelenght} sümbolit");
            }
            if (lastNamelenght == firstNamelenght)
            {
                Console.WriteLine("Mõlemas nimes on samapalju tähti!");
            }
            Console.Read();
        }
    }
}
