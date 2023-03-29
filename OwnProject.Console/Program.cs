using OwnProject.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OwnProjectConsole
{
    //. Jakie są produkty, których nie chciałabyś/ chciałbyś w diecie?

    static class Program
    {
        static void Main(string[] args)
        {
            User.MainUserData();

            var user = new User();

            Console.WriteLine($"Wartość: {user.GenderValue}.");
            Console.ReadKey();
            //HarrisBenedictPattern.BasicMetabolism();
        }
    }
}