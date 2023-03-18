using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wynik1 = ObjetoscProstokata(10, 3);
            Console.WriteLine(wynik1);
            string konkatenacja1 = KonkatenacjaWyrazow("Dominika", " to ", "Króliczek");
            Console.WriteLine(konkatenacja1);
            Console.ReadKey();
        }

        private static int ObjetoscProstokata(int bok1, int bok2)
        {
            int wynik;
            wynik = bok1 * bok2;
            return wynik;
        }
        private static string KonkatenacjaWyrazow(string a, string b, string c)
        {
            string konkatenacja = a + b + c;
            return konkatenacja;
        }
    }
}
