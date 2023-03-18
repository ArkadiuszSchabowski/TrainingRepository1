using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> kupon = new List<int>();
            kupon.Add(1);
            kupon.Add(2);
            kupon.Add(9);
            kupon.Add(7);
            kupon.Sort();
            foreach (int i in kupon) 
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

            List<int[]> liczby = new List<int[]>();
            liczby.Add(new int[6]);
            liczby.Add(new int[8]);




        }
    }
}
