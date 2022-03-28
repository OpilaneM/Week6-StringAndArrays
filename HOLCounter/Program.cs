using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis mitu 'h', 'o','l' tähte on lauses " Hello World"

            string helloW = "Hello  World!".ToLower();

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < helloW.Length; i++)
            {
                if (helloW [i] == 'h')
                {
                    hCounter++;

                }
                if (helloW [i] == 'o')
                {
                    oCounter++;
                }
                if (helloW [i] == 'l')
                {
                    lCounter++;
                }

            }
            Console.WriteLine($"Hello world sisaldab {hCounter} 'h' tähte, {oCounter} 'o' tähte ja {lCounter} 'l' tähte.");
            Console.Read();
        }
    }
}
