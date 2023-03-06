using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6MarchProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Niestatyczna niestatyczna = new Niestatyczna();
            niestatyczna.Metoda();
            Console.WriteLine();
            Number();
            Console.WriteLine();
            Statyczna.MetodaStatyczna();
            Console.ReadKey();

            void Number()
            {
                Console.WriteLine($"Number is {niestatyczna.Field}");
            }
        }
    }
    public static class Statyczna
    {
        public static void MetodaStatyczna()
        {
            for (int i = 0; i < 11; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            int j = 1;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
            }

            int[] tabela = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            foreach (var item in tabela)
            {
                Console.Write(item + " ");
            }
            var list = new List<int> { 6, 9, 6, 8 };
            Console.WriteLine();
            Console.WriteLine();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            ArrayList aray = new ArrayList();
            aray.Add("Aro");
            aray.Add(6);
            aray.Add("Dominika");
            aray.Add("9");

            foreach (var item in aray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(1, "Dominika");
            dictionary.Add(2, "Paulina");
            dictionary.Add(3, "Ania");

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

        }
    }
    public class Niestatyczna
    {
        public int Field { get; set; }
        private int field = 5;

        public Niestatyczna()
        {
            Field = field;
        }
        public void Metoda()
        {
            int firstVariable = 10;
            int secondVariable = 7;
            int sum;

            sum = firstVariable + secondVariable;
            Console.WriteLine(sum);
        }
    }
}
