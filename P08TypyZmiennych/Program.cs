using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P08TypyZmiennych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            char b = 'x';
            string c = "napis";
            double d = 8.54;

            string e = "23-11-2021";

            DateTime dt = new DateTime(2021, 11, 23);

            WebClient wc = new WebClient();
          //  wc.DownloadString(url)

            StringBuilder sb = new StringBuilder();
            sb.Append("ala");
            sb.Append("ma");
            sb.Append("kota");
            string s = sb.ToString();


        }
    }
}
