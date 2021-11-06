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
        public static void przez_metode(string wejscie)
        {
            int wartosc = 12;
            wartosc += Convert.ToInt32(wejscie);
            Console.WriteLine(wartosc);

        }
    }
}

///
//Poniższa tabela zawiera listę wbudowanych metod do konwersji typów:
//Metoda Opis
//ToBoolean	konwersja typu na typ logiczny - w miarę możliwości
//ToByte	konwersja typu na bajt
//ToChar	konwersja typu do pojedynczego znaku tablicy Unicode - w miarę możliwości
//ToDateTime	konwersja typu (liczba całkowita lub łańcuch znaków) do typu DateTime(data i godzina)
//ToDecimal   konwersja liczby zmiennoprzecinkowej lub liczb całkowitej do typu dziesiętnego
//ToDouble	konwersja typu do typu double (64-bitowa liczba zmiennoprzecinkowa)
//ToInt16 konwersja do 16-bitowej liczby całkowitej
//ToInt32	konwersja do 32-bitowej liczby całkowitej
//ToInt64	konwersja do 64-bitowej liczby całkowitej
//ToSbyte	konwersja do 8-bitowej liczb całkowitej
//ToSingle	konwersja do małej liczby zmiennoprzecinkowej
//ToString	konwersja typu do łańcucha tekstowego
//ToType	konwersja typu do określonego typu
//ToUInt16	konwersja do 16-bitowej liczby całkowitej (bez możliwości przechowywania liczb ujemnych)
//ToUInt32 konwersja do 32-bitowej liczby całkowitej (bez możliwości przechowywania liczb ujemnych)
//ToUInt64 konwersja do 64-bitowej liczby całkowitej (bez możliwości przechowywania liczb ujemnych)