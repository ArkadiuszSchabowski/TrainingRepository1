using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablica
{
    //    Napisz program, który wczytuje z wejścia ciąg liczb i wypisuje go w odwróconej kolejności.
    //Wejście
    //Na wejście programu podana zostanie pewna nieokreślona, ale niewielka ilość liczb całkowitych rozdzielonych spacjami.
    //Wyjście
    //Na wyjściu ma się pojawić ciąg liczbowy, którego i-ta pozycja jest równa (n+1-i)-tej liczbie wczytanej z wejścia, gdzie n to ilość wczytanych liczb.Poszczególne liczby należy rozdzielić spacjami.
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] tab = new int[5] { 4, 3, 2, 1, 6 };
            int[] tab2 = tab;

            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
            Console.ReadKey();
        }

    }
}