using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OwnTask
{
    class DisplayProgram
    {
    public static void Main(string[] args)
        {}
    }
    class LottoGame
    {
        //Gracz zgaduje 10 z 80 wylosowanych liczb przez maszynę. (potem wzbogacić program o ilość liczb)
        //Jeśli gracz trafi wszystkie wygrywa główną wygraną.

        Console.WriteLine("Podaj 10 liczb z zakresu od 1-80");
        int firstNumber = int.Parse(Console.Readline());
        int secondNumber = int.Parse(Console.Readline());
        int thirdNumber = int.Parse(Console.Readline());
        int fourthNumber = int.Parse(Console.Readline());
        int fifthNumber = int.Parse(Console.Readline());
        int sixthNumber = int.Parse(Console.Readline());
        int seventhNumber = int.Parse(Console.Readline());
        int eightNumber = int.Parse(Console.Readline());
        int nintethNumber = int.Parse(Console.Readline());
        int tenthNumber = int.Parse(Console.Readline());

        Random random1 = new Random();
        int los1 = random1(Next(1,80))
        Random random2 = new Random();
        int los2 = random2(Next(1,80))
        Random random3 = new Random();
        int los3 = random3(Next(1,80))
        Random random4 = new Random();
        int los4 = random4(Next(1,80))
        Random random5 = new Random();
        int los5 = random5(Next(1,80))
        Random random6 = new Random();
        int los6 = random6(Next(1,80))
        Random random7 = new Random();
        int los7 = random7(Next(1,80))
        Random random7 = new Random();
        int los8 = random8(Next(1,80))
        Random random8 = new Random();
        int los9 = random9(Next(1,80))
        Random random10 = new Random();
        int los1 = random10(Next(1,80))

        Console.ReadKey();
    }
}