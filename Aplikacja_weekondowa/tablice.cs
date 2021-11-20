using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_weekondowa
{
    class tablice
    {
        public static void mojaTablica()
        {
            //int[] oceny;
            //int[] oceny = new int[12];
            //oceny[0] = 2;
            //oceny[1] = 3;
            //oceny[2] = 3;
            //oceny[3] = 5;
            int[] oceny = new int[] { 5, 5, 6, 6, 6, 5, 6, 4 };

            //for (int i = 0; i < oceny.Length; i++)
            //{
            //    Console.WriteLine("pozycja:{0}, wartość: {1}",i,oceny[i]);
            //}
            foreach (var item in oceny)
            {
                Console.WriteLine("wartosc:{0}", item);
            }
        }
        public static void wielowymiarowa()
        {
            string[,,] szachy = new string[2, 8,4];
            szachy[0, 0,0] = "Wieża biała";
            szachy[0, 1,0] = "Pion biały";

           int abc=szachy.GetLength(2);
            Console.WriteLine(abc);
            Console.WriteLine(szachy.GetValue(0,1,0));
        }


    }
}
