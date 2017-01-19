using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            int sekunnit, minuutit, tunnit;

            Console.Write("Anna sekunnit > ");
            string line = Console.ReadLine();
            sekunnit = int.Parse(line);

            tunnit = sekunnit / 3600;
            minuutit = tunnit % 60;
            sekunnit = minuutit % 60;

            Console.WriteLine("Antamasi sekunttiaika voidaan ilmaista muodossa: {0} tunti(a) {1} minuutti(a) {2} sekunti(a) ", tunnit, minuutit, sekunnit);

        }
    }
}
