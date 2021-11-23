using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09WlasneKlasy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kod wykonawczy
            Kalkulator kalkulator = new Kalkulator();

            new Kalkulator();

            string napis;
            Kalkulator kalkulator1;

            Kalkulator kalkulator2 = new Kalkulator();

            int wynik= kalkulator.Dodaj(3, 4);

            Czlowiek c = new Czlowiek();
            c.Krzycz();

            c.Imie = "Jan";
            Console.WriteLine(c.Imie);

            Czlowiek c2 = new Czlowiek();
            c2.Imie = "Ola";

            Console.WriteLine(c.PrzedstawSie());
            Console.WriteLine(c2.PrzedstawSie());

            Console.ReadKey();
        }
    }
}
