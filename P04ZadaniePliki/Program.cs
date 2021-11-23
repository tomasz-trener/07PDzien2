using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadaniePliki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj sciezke do pliku");
            string sciezka = Console.ReadLine();
            Console.WriteLine("Podaj szukany wyraz");
            string wyraz = Console.ReadLine().ToLower();

            //string dane = File.ReadAllText(sciezka);

           // string[] tablica = File.ReadAllLines(sciezka);

            string dane = File.ReadAllText(sciezka).ToLower();

            //preprocessing danych 
            dane = dane.Replace("\r\n", " ");
            
            //                          
            // ala i tama ma kota i ma psa


            string[] tablica= dane.Split(' ');
            int suma = 0;
            for (int i = 0; i < tablica.Length; i++)
                if (tablica[i].Contains(wyraz))
                    suma++;

            Console.WriteLine(suma);

            //string[] tablica = da
        }
    }
}
