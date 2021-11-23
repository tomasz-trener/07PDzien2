using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03DostepDoPlikow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string sciezka = "c:\\dane\\dawodnicy.txt";
            string sciezka = @"c:\dane\zawodnicy.txt";

            string dane= File.ReadAllText(sciezka);

            string[] wiersze =
                dane.Split(new string[1] {"\r\n"}, StringSplitOptions.RemoveEmptyEntries);

            int liczbaWierszy = wiersze.Length-1;
            int liczbaKolumn = wiersze[0].Split(';').Length;

            // krok 1 wczytanie danych do tablicy dwu-wymiarowej 
            // tablica dwuwymiarowa
            string[,] tab1 = new string[liczbaWierszy,liczbaKolumn];

            for (int i = 0; i < liczbaWierszy; i++)
                for (int j = 0; j < liczbaKolumn; j++)
                {
                    string[] tmp = wiersze[i + 1].Split(';');
                    tab1[i,j] = tmp[j];
                }

            // krok 2 wczytanie danych do tablicy tablic 

            string[][] tab2 = new string[liczbaWierszy][];

            for (int i = 0; i < liczbaWierszy; i++)
                tab2[i] = wiersze[i + 1].Split(';');

            // krok 3 wyświetlenie danych z tab1 i z tab2
            // tablica dwu-wymiarowa
            for (int i = 0; i < liczbaWierszy; i++)
            {
                for (int j = 0; j < liczbaKolumn; j++)
                    Console.Write(tab1[i,j] + " ");
                Console.WriteLine();
            }
            //tablica tablic 

            Console.WriteLine("----------");

            for (int i = 0; i < liczbaWierszy; i++)
                Console.WriteLine(String.Join(" ", tab2[i]));
            

        }
    }
}
