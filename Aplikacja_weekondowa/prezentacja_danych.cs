using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_weekondowa.PrezentacjaDanych { 
    class PrezentacjaStringow
    {
        public static void wyswietl(string tekst,string a, string b)
        {
            Console.WriteLine(tekst, a, b);
        }

        public static void wyswietl2(string a, string b)
        {
            Console.WriteLine($"Mój string 1 ma wartość={a}, a drugi wynosi {b}");
        }
        public static void sciecha()
        {
            Console.WriteLine(@"D:\PRACA\WSB\CHORZOW\SIATKI i ECTS");
        }
    }

}