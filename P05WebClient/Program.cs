using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P05WebClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "ala\nma\nkota";

            string s2 = "ala " + Environment.NewLine +
                "ma" +
                "kota";

            string s3 = @"ala
ma
kota";
            
            string url = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";

            string dane=  new WebClient().DownloadString(url);

            // spotkamy się 12:40

        }
    }
}
