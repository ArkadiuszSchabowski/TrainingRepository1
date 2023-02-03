using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthBase
{
    internal class Program
    {
        //🔨 ZADANIE #5:

        //Wykorzystaj wiedzę ze wszystkich dotychczasowych lekcji i napiszesz kod, który będzie wykorzystywał liczby Fibonacciego.Stwórz metodę, która wygeneruje pierwsze 20 liczb ciągu Fibonacciego. Wskazówki:
        //z każdą iteracją pętli bierzesz ostatnie dwie liczby całkowite z listy, sumujesz je i dodajesz tę wartość do listy.Pętla powtarza się, dopóki nie dodasz 20 pozycji do listy. Dwudziesta liczba Fibonacciego to 6765
        static void Main(string[] args)
        {
            GenerateFirstTwentyNumbers();
        }
        static void GenerateFirstTwentyNumbers()
        {
            {
                {
                    int i = 0; int j = 0;
                    while (i<20)
                    {
                        while (j<60)
                        {
                            Console.WriteLine(j);
                            j++;
                            
                        }
                        Console.WriteLine(i);
                        i++;
                    }

                }
                Console.ReadKey();
            }
        }
    }
}
