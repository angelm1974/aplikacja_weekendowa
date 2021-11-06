using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_weekondowa.Sterowanie
{
    class SterowaniePrzeplywem
    {
        public static void wyswietl(string tekst, int a, int b)
        {
            // Sterowanie przepływem polecenie if z warunkiem logicznym
            if (a > 2 && b > 5)
            {
                Console.WriteLine(tekst);
            }
            else if (a > b || a!=5)
            {
                Console.WriteLine("A jest większe od B");
            }
            else
            {
                Console.WriteLine("Te wartości nie są równe");
            }
        }

    }

}
/// A = 10 oraz B = 20.
/// 
//Operator Opis	Przykład
//      ==	sprawdza czy wartości argumentów są równe, jeżeli tak zwraca flagę true	(A == B) false.
//      != sprawdza czy wartości argumentów są równe, jeżeli wartości nie są równe zwraca true	(A != B) true
//      > sprawdza czy wartość lewego argumentu jest większa od prawego, jeżeli tak zwraca flagę true	(A > B) false
//      < sprawdza czy wartość lewego argumentu jest mniejsza od prawego, jeżeli tak zwraca flagę true	(A < B) true
//      >= sprawdza czy argument po lewej stronie jest większy bądź równy argumentowi po prawej stronie, jeżeli tak zwraca flagę true	(A >= B) false
//      <= sprawdza czy argument po lewej stronie jest mniejszy bądź równy argumentowi po prawej stronie, jeżeli tak zwraca flagę true	(A <=B ) true

//Łączenie operatorów logicznych

//      Operator Opis	Przykład
//      &&	logiczny operator i. Jeżeli oba argumenty są zerowe to warunek jest prawdziwy	(A && B) false
//      || logiczny operator lub.Jeżeli którykolwiek z argumentów nie jest równy zero to warunek jest prawdziwy   (A || B) true
//      !   logiczny operator zaprzeczenia. Używany jest do zmiany stanu logicznego argumentu. Jeżeli argument jest prawdziwy to jego zastosowanie zmieni jego wartość na nieprawdziwą	!(A && B) true