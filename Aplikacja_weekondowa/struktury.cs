using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aplikacja_weekondowa
{
        struct samochod
        {
            public string nazwa;
            public string marka;
            public int iloscKol;
            public typy_wyliczeniowe.MojeKolory kolor;
            public typy_wyliczeniowe.LataProdukcji rokProdukcji;
        }
        struct osoba
    {
        public string imie;
        public string nazwisko;
        public samochod mojsamochod;
    }
    class struktury
    {
        public static void Samochody()
        {
            samochod Opel;
            samochod BMW;

            Opel.iloscKol = 4;
            Opel.kolor = typy_wyliczeniowe.MojeKolory.Niebieski;
            Opel.marka = "Opel";
            Opel.nazwa = "Adam";
            Opel.rokProdukcji = typy_wyliczeniowe.LataProdukcji.r_2;

            BMW.iloscKol = 6;
            BMW.kolor = typy_wyliczeniowe.MojeKolory.Czerwony;
            BMW.marka = "BMW";
            BMW.nazwa = "506";
            BMW.rokProdukcji = typy_wyliczeniowe.LataProdukcji.r_3;

            samochod[] mojeSamochody = new samochod[] { Opel, BMW };

            osoba Julek;
            Julek.imie = "Julek";
            Julek.nazwisko = "Abc";
            Julek.mojsamochod = Opel;

            foreach (var item in mojeSamochody)
            {
               // Console.ForegroundColor = (ConsoleCo)item.kolor;
                Console.WriteLine("Moje auto to : {0}, {1}, z rocznika {2}", item.marka, item.nazwa, item.rokProdukcji);
            }
        }
        //Opel, BMW, Fiat, Ponitiac
    }
}
