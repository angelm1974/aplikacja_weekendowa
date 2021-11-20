using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_weekondowa
{
    class funkcje
    {
        public static int ileRazyLitery(string tekst, char litera)
        {
            int zmienna = tekst.Count(x => x == litera);
            return zmienna;
        }


        public static int Silnia(int liczba)
        {
            int wynik;
            if (liczba == 1)
            {
                return 1;
            }
            else
            {
                wynik = Silnia(liczba - 1) * liczba;
                return wynik;
            }

        }


        public static void operator_porownania()
        {
            double? l1 = null;
            double? l2 = 3.14157;
            double l3;

            l3 = l1 ?? 5.25;

            Console.WriteLine("Wartość zmiennej l3: {0}", l3);
            l3 = l2 ?? l3;
            Console.WriteLine("Wartość zmiennej l3: {0}", l3);
        }

    }
}
