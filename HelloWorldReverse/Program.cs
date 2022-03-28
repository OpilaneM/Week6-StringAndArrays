using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Hello World" tagurpidi
            string helloW = "Hello World!";
            for (int i = helloW.Length-1; i >= 0; i--)
            {
                Console.Write(helloW[i]);
            }

            Console.Read();
        }
    }
}
