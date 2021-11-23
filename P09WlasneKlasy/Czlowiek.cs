using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09WlasneKlasy
{
    internal class Czlowiek
    {
        // kod deklaratywny 
        // 1) Pola  <- cechy obiektu
        // 2) Właściwości <-- bardziej złożone cechy (Pola=Właściwości)
        // 3) Konstruktory <-- określają w jaki sposób tworzymy dany obiekt 
        // 4) Metody       <-- określają co dany obiekt może zrobić (umiejętności)

        public string Imie;

        public string PrzedstawSie()
        {
            return "Nazywam się " + Imie;
        }

        public void Krzycz()
        {
            Console.WriteLine("aaaaaaaaaa!!!!");
        }

        public string Krzycz2()
        {
            return "aaaaaaaaa!!!!";
        }

    }
}
