using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P06ZadanieZawodnicy
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
            //List<string> list = new List<string>();

            //list.Add("ala");
            //list.Add("ma");
            //list.Add("kota");

            //list.RemoveAt(1);


            string url = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";

            string dane =  new WebClient().DownloadString(url);

            Console.WriteLine("Podaj nazwe kraju");
            string kraj = Console.ReadLine().ToLower();

            string[] wiersze=  dane.Split(new string[1] { "\r\n" },StringSplitOptions.RemoveEmptyEntries);

            List<string> imionaNazwiska = new List<string>();

            for (int i = 1; i < wiersze.Length; i++)
            {
                string[] komorki = wiersze[i].Split(';');
                if (komorki[4].ToLower() == kraj)
                {
                    imionaNazwiska.Add(komorki[2] + " " + komorki[3]);
                }
            }

            string sciezka = @"c:\dane\";

            File.WriteAllLines($"{sciezka}{kraj}.txt", imionaNazwiska);

        }
    }
}
