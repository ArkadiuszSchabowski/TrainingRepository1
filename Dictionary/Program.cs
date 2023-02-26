using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(4);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(9);

            queue.Dequeue();
            queue.Dequeue();
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Peek());
            Console.ReadKey();

            //Dictionary<int, string> dictionary = new Dictionary<int, string> {};

            //dictionary.Add(1, "Dominika");
            //dictionary.Add(2, "Paulina");
            //dictionary.Add(3, "Ania");

            //foreach (var item in dictionary)
            //{
            //    Console.WriteLine("{0}. {1}", item.Key, item.Value);
            //}
            //Console.ReadKey();

            //foreach (var item in dictionary)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            //List<string> kolekcja = new List<string>();

            //kolekcja.Add("Dominika");
            //kolekcja.Add("Monika");
            //kolekcja.Add("Patrycja");
            //kolekcja.Add("Paulina");
            //kolekcja.Insert(2, "Beata");

            //foreach (var item in kolekcja)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("");
            //Console.WriteLine($"Długość listy to: {kolekcja.Count}");
            //Console.ReadKey();

            //ArrayList lista = new ArrayList();
            //lista.Add("Dominika");
            //lista.Add("Króliczek");
            //lista.Add(6);

            //foreach (var item in lista)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();
        }
    }
}
