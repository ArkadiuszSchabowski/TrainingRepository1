using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
            int sum = 0;
            for (int i = 1; i <= 30; i++)

                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                    sum += i;
                }
            Console.WriteLine("");
            Console.WriteLine($"Suma liczb to: {sum}.");
            Console.ReadKey();
        }
    }
}