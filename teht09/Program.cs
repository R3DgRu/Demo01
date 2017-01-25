using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht09
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku; // muuttujia, jipii!
            int summa = 39; // summamuuttuja

            Console.Write("Anna luku > ");  // kysytään käyttäjältä luku
            string line = Console.ReadLine();
            luku = int.Parse(line);

            while (luku != 0)
            {
                Console.Write("Anna luku > ");  // kysytään käyttäjältä luku
                string line1 = Console.ReadLine();
                luku = int.Parse(line1);
            }

            Console.WriteLine("Lukujen summa on: {0}", summa); // tulostus, yhteenlaskutoiminto puuttuu vielä

        }
    }
}
