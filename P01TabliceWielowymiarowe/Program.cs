using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01TabliceWielowymiarowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tab1 = new string[3] { "ala", "jan", "adam" };

            string[,] tab2 = new string[3, 4];

            tab2[0, 0] = "01";
            tab2[1, 0] = "02";
            tab2[2, 0] = "03";

            tab2[0, 1] = "04";
            tab2[1, 1] = "05";
            tab2[2, 1] = "06";

            tab2[0, 2] = "07";
            tab2[1, 2] = "08";
            tab2[2, 2] = "09";

            tab2[0, 3] = "10";
            tab2[1, 3] = "11";
            tab2[2, 3] = "12";

            int dlugoscTab = tab2.Length; //12
            int dlugWym0 = tab2.GetLength(0); //3
            int dlugWym1 = tab2.GetLength(1); //4

            for (int i = 0; i < dlugWym0; i++)
            {
                for (int j = 0; j < dlugWym1; j++)
                {
                    Console.Write(tab2[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("----------");

            for (int i = 0; i < dlugWym1; i++)
            {
                for (int j = 0; j < dlugWym0; j++)
                {
                    Console.Write(tab2[j, i] + " ");
                }
                Console.WriteLine();
            }

            int[,,] tab3 = new int[3, 3, 3];
            tab3[0, 0, 0] = 1;

            // 90% tab-1
            // 9% tab-2
            // 1% tab-3 lub wiecej (badania naukowe ) 


            List<string> lista = new List<string>();
            // list dwu-wymiarowych nie ma ...

            // możemy zrobić listę list

            List<List<string>> listaList = new List<List<string>>();
            listaList.Add(new List<string>());
            listaList.Add(new List<string>());

            listaList[0].Add("ala");
            listaList[0].Add("ola");

            listaList[1].Add("jan");
            listaList[1].Add("lukasz");

            int dlugosc =  listaList.Count; //2 


            Console.ReadKey();
        }
    }
}
