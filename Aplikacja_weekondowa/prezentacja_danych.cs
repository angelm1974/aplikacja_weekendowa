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
            Console.WriteLine($"Mój string\t\t 1 ma wartość={a},\n a drugi wynosi {b}\a");
        }
        public static void sciecha()
        {
            Console.WriteLine(@"D:\PRACA\WSB\CHORZOW\SIATKI i ECTS");
        }
    }

}

///
        //Sekwencja ucieczki	Znaczenie
        //  \\	znak \
        //  \'	znak '
        //  \"	znak "
        //  \?	znak ?
        //  \a	z głośników usłyszmy pojedyczny brzęczyk (beep)
        //  \b znak backspace (cofamy kursor o jedną pozycję)
        //  \n nowa linia
        //  \r	powrót kursora na początek obecnej linii
        //  \t	znak tabulacji (odstęp)
        //  \v pionowy znak tabulacji
        //  \ooo	liczba ósemkowa o jednej lub większej liczbie cyfr
        //  \xhh	liczba szestastkowa o jednej lub większej liczbie cyfr
