using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm asendab k]ik 'o' t2hed laused "Dont panic" nulliga - o
            // programm asendab k]ik 'a' t2hed samas lauses 4-ga
            string Dpanic = "Dont Panic.";
            Dpanic = Dpanic.Replace('o', '0');
            Dpanic = Dpanic.Replace('a', '4');
            Console.WriteLine(Dpanic);
            Console.Read();
        }
    }
}
