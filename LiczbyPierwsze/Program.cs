using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LiczbyPierwsze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10] { 3, 4, 2, 1, 6, 5, 4, 3, 2, 1 };
            int sum = 0;
            int srednia = 0;
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i]);
                sum += n[i];
            }
            Console.WriteLine($"Suma ocen w tablicy to {sum}.");
            srednia = sum / n.Length;
            Console.WriteLine($"Twoja suma ocen w tablicy to {srednia}");
            Console.ReadKey();
        }
    }
}