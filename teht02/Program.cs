using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            // kysyy pisteet
            int pisteet;
            Console.Write("Anna pistemaara > ");
            string line = Console.ReadLine(); 
            pisteet = int.Parse(line); 
            
            switch (pisteet)
            {
                case 0: Console.Write("Koulunumero on 0"); break;
                case 1: Console.Write("Koulunumero on 0"); break;
                case 2: Console.Write("Koulunumero on 1"); break;
                case 3: Console.Write("Koulunumero on 1"); break;
                case 4: Console.Write("Koulunumero on 2"); break;
                case 5: Console.Write("Koulunumero on 2"); break;
                case 6: Console.Write("Koulunumero on 3"); break;
                case 7: Console.Write("Koulunumero on 3"); break;
                case 8: Console.Write("Koulunumero on 4"); break;
                case 9: Console.Write("Koulunumero on 4"); break;
                case 10: Console.Write("Koulunumero on 5"); break;
                case 11: Console.Write("Koulunumero on 5"); break;
                case 12: Console.Write("Koulunumero on 5"); break;
            }
            // Wait enter
            Console.ReadLine();
        }
    }
}
