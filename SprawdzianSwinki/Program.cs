using System;

class Zwierzak
    {
        private int _waga;

    public int PobierzWage()
    {
        return _waga;
    }

    public void UstawWage(int waga)
        {
            _waga = waga;
        }
    }

    class Program

    {
        static void Main(string[] args)
        {
            Zwierzak Kropka = new Zwierzak();
            Zwierzak Kreska = new Zwierzak();

            Kropka.UstawWage(1100);
            System.Console.WriteLine("Waga Kropki to " + Kropka.PobierzWage());
            System.Console.ReadKey();
        Console.WriteLine("");
        Console.Clear();

        Kreska.UstawWage(1120);
        System.Console.WriteLine("Waga Kreski to " + Kreska.PobierzWage());
        System.Console.ReadKey();
    }
    }
