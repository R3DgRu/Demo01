using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            double matka, litrat, kustannukset, valivaihe;
            double kulutus = 7.02; // auton kulutus litraa sadalla kilometrillä
            double polt_hinta = 1.595; // polttoaineen hinta litralta euroissa

            // käyttäjä kertoo ajetun matkan
            Console.Write("Anna matka kilometreissa > ");
            string line = Console.ReadLine();
            matka = double.Parse(line);

            // laskutoimitus laskee kuluneet litrat ja tämän perusteella kustannukset 
            valivaihe = matka * kulutus;
            litrat = valivaihe / 100;
            kustannukset = litrat * polt_hinta;

            // tulostaa lopuksi kuluneet litrat ja aiheutuneet kustannukset
            Console.WriteLine("Polttoainetta kuluu {0} litraa, kustannus {1} euroa", litrat, kustannukset);

        }
    }
}
