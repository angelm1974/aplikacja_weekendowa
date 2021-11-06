using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_weekondowa
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine(Funkcje.Matematyczne.add(2, 5));
            Konwersje.Niejawne.numer(12);
            Konwersje.Jawne.numer(1);
            //Console.WriteLine("Podaj liczbę: ");
            //Konwersje.Jawne.przez_metode(Console.ReadLine());
            //PrezentacjaDanych.PrezentacjaStringow.wyswietl("Mój string {0}, a drugi {1}","zerową", "465 lub 456");
            //PrezentacjaDanych.PrezentacjaStringow.wyswietl2("zerową", "465 lub 456");
            Sterowanie.SterowaniePrzeplywem.wyswietl("Miło Cię widzieć", 2, 7);
            Sterowanie.SterowaniePrzeplywem.pokazSwitch(10);
            Console.ReadKey();
        }


    }
}
