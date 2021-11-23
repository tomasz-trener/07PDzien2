using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02TablicePostrzepione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //jagged array 
            // tablica postrzępiona znana też jako tablica tablic 

            string[] tab1 = new string[3];

            string[][] tab2 = new string[3][];
            tab2[0] = new string[2];
            tab2[1] = new string[3];
            tab2[2] = new string[1];

            tab2[0][0] = "ala";
            tab2[0][1] = "jan";

            tab2[1][1] = "ola";

            int dlugTab = tab2.Length; //3
                                       
            int dlugTab0 = tab2[0].Length;






        }
    }
}
