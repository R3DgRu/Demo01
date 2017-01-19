using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht07
{
    class Program
    {
        static void Main(string[] args)
        {
            int vuosi;

            Console.Write("Anna vuosiluku > ");
            string line = Console.ReadLine();
            vuosi = int.Parse(line);

            if (vuosi % 4 == 0 && vuosi % 100 != 0 || vuosi % 400 == 0)
            {
                Console.WriteLine("karkausvuosi");
            } else
            {
                Console.WriteLine("ei ole karkausvuosi");
            }
            
        }
    }
}
