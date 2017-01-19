using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht08
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2, luku3; // luku1, 2 ja 3 nimiset muuttujat

            Console.Write("Anna luku > ");  // kysytään käyttäjältä ensimmäinen luku
            string line1 = Console.ReadLine();
             luku1 = int.Parse(line1);

            Console.Write("Anna luku > ");  // kysytään käyttäjältä toinen luku
            string line2 = Console.ReadLine();
            luku2 = int.Parse(line2);

            Console.Write("Anna luku > ");  // kysytään käyttäjältä kolmas luku
            string line3 = Console.ReadLine();
            luku3 = int.Parse(line3);

            if (luku1 > luku2 && luku1 < luku3) Console.WriteLine(luku1);
            else if (luku2 > luku1 && luku2 > luku3) Console.WriteLine(luku2);
            else if (luku3 > luku2 && luku3 > luku1)Console.WriteLine(luku3);
            

            

        }
    }
}
