using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleList
{
    internal class Program
    {

        static void Main(string[] args)
        {
            DoubleList();
        }

        private static void DoubleList()
        {
            List<List<string>> model = new List<List<string>>();

            List<string> rodzaj = new List<string>();

            rodzaj.Add("Sedan");
            rodzaj.Add("Hatchback");
            rodzaj.Add("Kombi");

            model.Add(rodzaj);

            foreach (List<string> rodzajek in model)
            {
                foreach (string item in rodzajek)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadKey();


        }
    }
}
