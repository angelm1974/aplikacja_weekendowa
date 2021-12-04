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
        public static void listaRzeczyDoZrobienia()
        {
  
            foreach (var item in mojaLista)
            {
                Console.WriteLine(item.doZrobienia +" " + item.kiedyWstawiono.ToString("T"));
            }
            Console.ReadKey();
        }


        public static void addDolistaRzeczyDoZrobienia(string coJestDoZrobienia)
        {
            elementTODO dodawany= new elementTODO();
            dodawany.doZrobienia = coJestDoZrobienia;
            dodawany.czyZrobione = false;
            dodawany.kiedyWstawiono = DateTime.Now;
            dodawany.ktoZrobil = "";

            mojaLista.Add(dodawany);
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
