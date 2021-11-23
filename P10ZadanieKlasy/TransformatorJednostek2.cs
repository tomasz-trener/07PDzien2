using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10ZadanieKlasy
{
 

    internal class TransformatorJednostek2
    {
        /// <summary>
        /// Ta metoda pozwala na konwersję jednostki z jednego typu na drugi
        /// </summary>
        /// <param name="temperatura">to jest temp do przetworzenia</param>
        /// <param name="jednDocelowa">podaj jednostkę docelową: c lub f lub k</param>
        /// <param name="jednWejsciowa">podaj jednostkę wyjsciową: c lub f lub k</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        /// <exception cref="Exception"></exception>
        public double ZamienTemperature(double temperatura, char jednDocelowa, char jednWejsciowa )
        {
            if (jednDocelowa == 'f' && jednWejsciowa == 'c')
            {
                return temperatura * 1.8 + 32;
            }

            if (jednDocelowa == 'k' && jednWejsciowa == 'c')
            {
                return (temperatura +273.1) * 1.8;
            }

            if (jednDocelowa == 'c' && jednWejsciowa == 'f')
            {
                throw new NotImplementedException();
            }

            if (jednDocelowa == 'k' && jednWejsciowa == 'f')
            {
                throw new NotImplementedException();
            }

            if (jednDocelowa == 'c' && jednWejsciowa == 'k')
            {
                throw new NotImplementedException();
            }

            if (jednDocelowa == 'f' && jednWejsciowa == 'k')
            {
                throw new NotImplementedException();
            }

            throw new Exception("Podałeś złą jednostkę");
           // return 0;

        }
    }
}
