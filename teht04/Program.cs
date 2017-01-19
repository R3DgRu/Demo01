using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            int ika;

            // kysyy käyttäjän iän
            Console.Write("Syota ikasi: ");
            string line = Console.ReadLine();
            ika = int.Parse(line);

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
