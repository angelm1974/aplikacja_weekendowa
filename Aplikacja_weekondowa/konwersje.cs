using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_weekondowa.Konwersje
{
    class Niejawne
    {
        public static void numer(int number1)
        {
            Console.WriteLine((number1 + 33.4).GetType());
        }
        /// Tutaj napisz funkcje multiplay and divide

    }

    class Jawne
    {
        public static void numer(int number1)
        {
            int wartosc;
            wartosc = (int)(number1 + 33.4);
            Console.WriteLine(wartosc.GetType());
        }
        /// Tutaj napisz funkcje multiplay and divide

    }
}