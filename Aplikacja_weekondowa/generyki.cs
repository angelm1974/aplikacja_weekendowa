using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_weekondowa
{
    class generyki
    {
        public static void prostaListaGeneryczna()
        {
            List<String> mojaLista = new List<string>() { "Opel", "BMW", "Dacia" };
            mojaLista.Add("Pontiac");
            foreach (var item in mojaLista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        public static List<elementTODO> mojaLista = new List<elementTODO>();

        /// <summary>
        /// wyswietla liste generyczna z zadaniami do zrobienia
        /// </summary>
        public static void wyswietlListeRzeczyDoZrobienia()
        {
            var i = 0;

            foreach (var item in mojaLista)
            {
                i = +1;
                Console.WriteLine($"{i.ToString()}. do zrobienia: {item.doZrobienia} " +
                    $"wstawiono: {item.kiedyWstawiono.ToString("f")}  \n " +
                    $"na kiedy: {item.kiedyZrobiono.ToString("f")} kto: {item.ktoZrobil}");
            }
            Console.WriteLine($"Liczba zadań: {mojaLista.Count()}");

        }

        /// <summary>
        /// odpowiada za dodawanie nowego elementu do listy rzeczy do zrobienia 
        /// </summary>
        /// <param name="coJestDoZrobienia">ciąg reprezentujący informacje co jest do zrobienia</param>
        public static void addDolistaRzeczyDoZrobienia(string coJestDoZrobienia)
        {
            elementTODO dodawany = new elementTODO();
            dodawany.doZrobienia = coJestDoZrobienia;
            dodawany.czyZrobione = false;
            dodawany.kiedyWstawiono = DateTime.Now;
            dodawany.ktoZrobil = "";

            mojaLista.Add(dodawany);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="elementListy"></param>
        public static void editListaRzeczyDoZrobienia(int elementListy, string kto)
        {
            elementTODO edytowany = mojaLista[elementListy];
            edytowany.kiedyZrobiono = DateTime.Now;
            edytowany.ktoZrobil = kto;
            mojaLista[elementListy] = edytowany;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="elementListy"></param>
        public static void deleteListaRzeczyDoZrobienia(int elementListy)
        {
            Console.WriteLine($"Element:  {mojaLista[elementListy].doZrobienia} - ZOSTANIE USUNIĘTY");
            mojaLista.RemoveAt(elementListy);

        }

        public static void menu()
        {
            ConsoleKeyInfo input;
            do
            {
                input = Console.ReadKey();
                Console.WriteLine(input.Key);
            } while (input.Key != ConsoleKey.Q);
        }
    }



    struct elementTODO
    {
        public string doZrobienia;
        public bool czyZrobione;
        public DateTime kiedyWstawiono;
        public DateTime kiedyZrobiono;
        public string ktoZrobil;
    }
}
