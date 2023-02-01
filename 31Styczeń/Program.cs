using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace fourthBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            fourthBase();
        }
  
        static void fourthBase()
        //Napisz przy użyciu pętli oraz instrukcji if kod, który znajdzie sumę wszystkich 
        //liczb całkowitych od 1 do 30, które są podzielne przez 7. Wskazówka - użyj modulo.
        {
            int x1, x2, x3, x4, result;
            for (int i = 1; i <= 30; i++)

                if (i % 7 == 0)
                {
                    Console.WriteLine((i));
                }
            Console.WriteLine("Oto liczby, które są podzielne przez 7.\nAby uzyskać sumę tych liczb wprowadź wyświetlone liczby:");
            Console.Write("Przepisz 1 liczbę ");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("Przepisz 2 liczbę ");
            x2 = int.Parse(Console.ReadLine());
            Console.Write("Przepisz 3 liczbę ");
            x3 = int.Parse(Console.ReadLine());
            Console.Write("Przepisz 4 liczbę ");
            x4 = int.Parse(Console.ReadLine());

            result = x1 + x2 + x3 + x4;
            Console.WriteLine($"Twój wynik to: {result}.");
            Console.ReadKey();
        }
    }
}