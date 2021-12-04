using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_weekondowa
{
    class generyki2
    {
        static int indeks=0;
        public static Dictionary<int, elementTODO> mojSlownik = new Dictionary<int, elementTODO>();
        public static void addToDct(string coJestDoZrobienia)
        {
            elementTODO dodawany = new elementTODO();
            dodawany.doZrobienia = coJestDoZrobienia;
            dodawany.czyZrobione = false;
            dodawany.kiedyWstawiono = DateTime.Now;
            dodawany.ktoZrobil = "";
            mojSlownik.Add(indekser(), dodawany);
        }


        public static void wyswietlListeRzeczyDoZrobienia()
        {
          
            foreach (var item in mojSlownik)
            {
              
                Console.WriteLine($"\r\n{item.Key}. do zrobienia: {item.Value.doZrobienia} " +
                    $"wstawiono: {item.Value.kiedyWstawiono.ToString("f")}  \n " +
                    $"na kiedy: {item.Value.kiedyZrobiono.ToString("f")} kto: {item.Value.ktoZrobil}");
            }
            Console.WriteLine($"Liczba zadań: {mojSlownik.Count()}");

        }
        public static elementTODO findFirst(int klucz)
        {
            //return mojSlownik[klucz]; 
            return mojSlownik.FirstOrDefault(k => k.Key==klucz).Value;
           //return mojSlownik.FirstOrDefault(k => k.Value.ktoZrobil=="Jan").Value;
        }


        static int indekser()
        {
            indeks += 1;
            return indeks;
        }
    }
}
