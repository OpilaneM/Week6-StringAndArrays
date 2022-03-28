using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab k6ik 'o' t2hed lauses "Hello World!" t2rniga '*'

          string helloW = "Hello World!";
            //for(int i = 0; i < helloW.Length; i++)
            {
              //  helloW[i] = '*'; //s6ned on muutumatu
            }//
            helloW = helloW.Replace('o', '*');
            helloW = helloW.Replace('!', '1');
            Console.WriteLine(helloW);
            Console.Read();
        }
    }
}
