using System;

class Program
{
    static void Main(string[] args)
    {
        //Oblicz programem średnią arytmetyczną z podanych liczb
        //int srednia = iloscLiczb / wartosciLiczb;
        double sumaLiczb = 0;

        Console.WriteLine("Podaj ilość liczb");
        int IloscLiczb = int.Parse(Console.ReadLine());
        int[] iloscLiczb = new int[IloscLiczb];

        for (int i = 0; i < iloscLiczb.Length; i++)
        {
            Console.WriteLine($"Podaj liczbę: {i + 1}");
            iloscLiczb[i] = int.Parse(Console.ReadLine());
            sumaLiczb += iloscLiczb[i];
        }
        Console.WriteLine(sumaLiczb);
        Console.WriteLine("Średnia ocen to: " + Math.Round(sumaLiczb / IloscLiczb, 2));
        Console.ReadKey();
    }
}