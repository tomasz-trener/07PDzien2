using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10ZadanieKlasy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TransformatorJednostek tj = new TransformatorJednostek();

            double wynik= tj.KonwertujCelFar(32);

            TransformatorJednostek2 tj2 = new TransformatorJednostek2();
            tj2.ZamienTemperature(30, 'k', 'c');

            TransformatorJednostek3 tj3 = new TransformatorJednostek3();
            tj3.ZamienTemperature(30, JednostkaTemperatury.Celcjusz, JednostkaTemperatury.Klewin);

            // programowanie obiektowe 

            string[] s = "ala ma kota".Split(new string[1] {" "},StringSplitOptions.RemoveEmptyEntries);
            

        }
    }
}
