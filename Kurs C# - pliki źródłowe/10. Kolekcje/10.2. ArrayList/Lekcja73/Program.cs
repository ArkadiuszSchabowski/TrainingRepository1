using System;
using System.Collections;

namespace Lekcja73
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(5);
            arrayList.Add(15);
            arrayList.Add(-5);
            arrayList.Add(10);
            //Console.WriteLine(arrayList[0]);
            //Console.WriteLine(arrayList[1]);
            arrayList.Insert(0, "Element");
            Test t = new Test();
            arrayList.Add(t);
            arrayList.Remove("Element");
            arrayList.RemoveAt(4);

            arrayList.Sort();
            arrayList.Reverse();

            arrayList.Clear();

            Console.WriteLine("Ilość elementów: " + arrayList.Count);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
                if (item is Test)
                {
                    ((Test)item).SayHi();
                }
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
