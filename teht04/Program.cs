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

            if (ika < 18) Console.WriteLine("alaikainen");
            else if (ika >= 18 && ika <= 65) Console.WriteLine("aikuinen");
            else if (ika > 65) Console.WriteLine("seniori");

            // Wait enter
            Console.ReadLine();
        }
    }
}
