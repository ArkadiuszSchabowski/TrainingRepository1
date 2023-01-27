using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle1 r = new Rectangle1();
            r.Zmienne();
            r.Podsumowanie();
            Console.ReadKey();
        }
    }
}
class Rectangle1
{
    // Zmienne użytkownika
    double dlugosc;
    double szerokosc;
    // Metoda ustawiająca wartości parametrów na starcie
    public void Zmienne()
    {
        dlugosc = 10;
        szerokosc = 20;
    }
    public void Podsumowanie()
    {
        Console.WriteLine("dlugosc: " + dlugosc);
        Console.WriteLine("szerokosc: " + szerokosc);
    }
}
    