﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SzybkiProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int wysokoscDrabiny;
            Console.WriteLine("Podaj wysokość drabiny");
            wysokoscDrabiny = int.Parse(Console.ReadLine());
            for (int i = 0; i < wysokoscDrabiny; i++)
            {
                for (int j = 0; j < wysokoscDrabiny; j++)
                {
                    if (i%2==1)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
