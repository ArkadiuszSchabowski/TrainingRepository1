using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AprilCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisz program, który pobiera od użytkownika dwie liczby całkowite i wyświetla na ekranie ich sumę, różnicę, iloczyn oraz iloraz. Zwróć uwagę na obsługę błędów, takie jak wprowadzenie przez użytkownika błędnych danych(np.niecałkowitej liczby lub litery zamiast cyfry).
            Exercise6();
        }
        static void Exercise6()
        {
            try
            {
                int Addition;
                Console.WriteLine("Podaj pierwszą liczbę");
                int numberOne = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj drugą liczbę");
                int numberTwo = int.Parse(Console.ReadLine());

                Addition = numberOne + numberTwo;

                Console.WriteLine(Addition);
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Ups! Coś poszło nie tak, ale pracujemy nad tym");
                Console.ReadKey();
            }
        }


        static void Exercise4()
        {
            try
            {
                int Addition;
                Console.WriteLine("Podaj pierwszą liczbę");
                int numberOne = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj drugą liczbę");
                int numberTwo = int.Parse(Console.ReadLine());

                Addition = numberOne + numberTwo;

                Console.WriteLine(Addition);
                Console.ReadKey();
            }
            catch (FormatException e)
            {
                Console.WriteLine("Ups! Coś poszło nie tak, ale pracujemy nad tym: " + e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Ups! Coś poszło nie tak, ale pracujemy nad tym: " + e.Message);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Ups! Coś poszło nie tak, ale pracujemy nad tym: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ups! Coś poszło nie tak, ale pracujemy nad tym: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Koniec programu");
            }
            Console.ReadLine();
        }
        static void Exercise5()
        {
            try
            {
                int Addition;
                Console.WriteLine("Podaj pierwszą liczbę");
                int numberOne = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj drugą liczbę");
                int numberTwo = int.Parse(Console.ReadLine());

                Addition = numberOne + numberTwo;

                Console.WriteLine(Addition);
                Console.ReadKey();
            }
            catch (FormatException e)
            {
                Console.WriteLine("Ups! Coś poszło nie tak, ale pracujemy nad tym: " + e.Message);
                throw;
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Ups! Coś poszło nie tak, ale pracujemy nad tym: " + e.Message);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Ups! Coś poszło nie tak, ale pracujemy nad tym: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ups! Coś poszło nie tak, ale pracujemy nad tym: " + e.Message);
            }
        }
        static void Exercise3()
        {
            int numberOne;
            int numberTwo;
            int suma;
            int roznica;
            int iloczyn;
            int iloraz;

            Console.WriteLine("Podaj pierwszą liczbę całkowitą");
            bool result = int.TryParse(Console.ReadLine(), out numberOne);
            Console.WriteLine("Podaj drugą liczbę całkowitą");
            bool result2 = int.TryParse(Console.ReadLine(), out numberTwo);
            Console.WriteLine();

            suma = numberOne + numberTwo;
            roznica = numberOne - numberTwo;
            iloczyn = numberOne * numberTwo;
            iloraz = numberOne / numberTwo;

            string text = result && result2 ? ($"Suma: {suma} + Roznica: {roznica} + Iloczyn: {iloczyn} + Iloraz: {iloraz}") : "Przynajmniej jedna z wartości jest nieprawidłowa";

            Console.WriteLine(text);
            Console.ReadKey();
        }
        static void Exercise2()
        {
            Console.WriteLine("Podaj pierwszą liczbę całkowitą");
            int numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj pierwszą drugą całkowitą");
            int numberTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj pierwszą trzecią całkowitą");
            int numberThree = int.Parse(Console.ReadLine());
            Console.WriteLine("Komputer sprawdzi teraz czy liczba środkowa jest parzysta oraz czy wszystkie liczby są równe lub wszystkie są różne\n");

            string result = numberTwo % 2 == 0 && (numberOne == numberTwo) && (numberOne == numberThree) && (numberTwo == numberThree) ? "Środkowa liczba jest parzysta oraz wszystkie liczby są równe" : "Środkowa liczba jest nieparzysta lub wszystkie liczby nie są równe";
            Console.WriteLine(result);
            Console.ReadKey();
        }
        static void Exercise1()
        {
            int number;
            Console.WriteLine("Podaj liczbę całkowitą");
            Console.WriteLine("Komputer sprawdzi czy liczba jest liczbą nieparzystą większą od 10");
            bool condition = int.TryParse(Console.ReadLine(), out number);

            string result = condition && number % 2 == 1 && number > 10 ? "Liczba nieparzysta większa od 10" : "Inna wartość";
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}