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
                i += 1;
                Console.WriteLine($"\r\n{i.ToString()}. do zrobienia: {item.doZrobienia} " +
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
            elementTODO edytowany = mojaLista[(elementListy-1)];
            edytowany.kiedyZrobiono = DateTime.Now;
            edytowany.ktoZrobil = kto;
            mojaLista[(elementListy - 1)] = edytowany;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="elementListy"></param>
        public static void deleteListaRzeczyDoZrobienia(int elementListy)
        {
            Console.WriteLine($"Element:  {mojaLista[(elementListy-1)].doZrobienia} - ZOSTANIE USUNIĘTY");
            mojaLista.RemoveAt(elementListy - 1);

        }

        public static void menu()
        {
            Wyswietl();

            ConsoleKeyInfo input;
            do
            {
                input = Console.ReadKey();

                switch (input.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("\r\nNapisz co jest do zrobienia:");
                        addDolistaRzeczyDoZrobienia(Console.ReadLine());
                        Wyswietl();
                        break;
                    case ConsoleKey.E:
                        Console.WriteLine("\r\nWybierz element do edycji:");
                        int nmb = int.Parse(Console.ReadLine());
                        Console.WriteLine("\r\nKto wykonał zadanie:");
                        editListaRzeczyDoZrobienia(nmb, Console.ReadLine());
                        Wyswietl();
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine("\r\nWybierz element do skasowania:");
                        int nr = int.Parse(Console.ReadLine());
                        deleteListaRzeczyDoZrobienia(nr);
                        Wyswietl();
                        break;
                    case ConsoleKey.L:
                        wyswietlListeRzeczyDoZrobienia();
                        Wyswietl();
                        break;
                    case ConsoleKey.Q:
                        break;
                    default:
                        Console.WriteLine("\r\nNie ma takiego elementu w menu!!!");
                        Wyswietl();
                        break;
                }

            } while (input.Key != ConsoleKey.Q);
        }

        private static void Wyswietl()
        {
            Console.Write("\r\nNacisnij coś... ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Wybierz opcje:");
            Console.WriteLine("L - lista zadań");
            Console.WriteLine("A - Nowe zadanie");
            Console.WriteLine("E - Edytuj zadanie");
            Console.WriteLine("D - Kasuj zadanie");
            Console.WriteLine("Q - Wyjdź z programu");
            Console.WriteLine("Wybierz opcję:\r\n ");
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
