using System;
using System.Collections.Generic;

namespace Lekcja74
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(5);
            list.Add(15);
            list.Add(-5);
            list.Add(10);
            list[0] = 1;
            //list.Add("Element"); - błąd

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            List<Test> list2 = new List<Test>();
            list2.Add(new Test());
            list2.Add(new Test());
            list2.Add(new Test());

            foreach (var item in list2)
            {
                item.SayHi();
            }
        }
    }






    class Test
    {
        public void SayHi()
        {
            Console.WriteLine("Hello!");
        }
    }
}
