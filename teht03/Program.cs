using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2, luku3, summa, valisumma, keskiarvo;

            // kysyy ensimmäisen numeron
            Console.Write("Syota ensimmainen luku > ");
            string line = Console.ReadLine();
            luku1 = int.Parse(line);

            // kysyy toisen numeron
            Console.Write("Syota toinen luku > ");
            string line2 = Console.ReadLine();
            luku2 = int.Parse(line2);

            // kysyy kolmannen numeron
            Console.Write("Syota kolmas luku > ");
            string line3 = Console.ReadLine();
            luku3 = int.Parse(line3);

            // laskutoimitukset
            summa = luku1 + luku2 + luku3;

            valisumma = luku1 + luku2 + luku3;

            keskiarvo = valisumma / 3;

            //tulostus
            Console.WriteLine("Summa: " + summa);
            Console.Write("Keskiarvo: " + keskiarvo);

            // Wait enter
            Console.ReadLine();
        }
    }
}
