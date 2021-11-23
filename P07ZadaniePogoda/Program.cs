using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P07ZadaniePogoda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string urlSerwisu = "https://www.google.pl/search?q=pogoda";
            while (true)
            {
                Console.WriteLine("Podaj miasto");
                string miasto = Console.ReadLine();
                string url = $"{urlSerwisu} {miasto}";

                string dane = new WebClient().DownloadString(url);

               // File.WriteAllText(@"c:\dane\pogoda.html", dane);
                string ciag = "°C";

                int idx = dane.IndexOf(ciag);
                int aktualnyIdx = idx - 1;
                while (dane[aktualnyIdx] != '>')
                    aktualnyIdx--;

                string wynik = dane.Substring(aktualnyIdx + 1, idx - aktualnyIdx + 1);
                Console.WriteLine(wynik);

                //wether(miasto);
            }



        }

        static void wether(string city)
        {
            string query = "https://www.google.com/search?q=pogoda " + city;
            string data = new WebClient().DownloadString(query);
            //Console.WriteLine(data);
            int index_temp = data.IndexOf('°');
            string temp = data.Substring(index_temp - 2, 3);
            Console.WriteLine(temp);
            Console.WriteLine(index_temp);
        }
    }
}
