using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfAnimals = new List<string>();

            listOfAnimals.Add("Pies");
            listOfAnimals.Add("Kot");
            listOfAnimals.Add("Zmija");
            listOfAnimals.Add("Kon");
            listOfAnimals.Add("Anakonda");
            listOfAnimals.Add("Bizon");
            listOfAnimals.Add("Czapla");
            listOfAnimals.Add("Dzik");

            List<int> listOfNumbers = new List<int>() {5,10,15,20,21,1,4,7,16};

            listOfNumbers.Where(i => i);
        }
    }
}
