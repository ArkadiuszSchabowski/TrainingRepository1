using System;
using System.Diagnostics;
using System.Text;

namespace Lekcja62
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string t1 = CreateStringByAdd(100000);
            stopwatch.Stop();
            Console.WriteLine($"Czas +: {stopwatch.ElapsedMilliseconds}");

            stopwatch.Restart();
            string t2 = CreateStringByStringBuilder(100000);
            stopwatch.Stop();
            Console.WriteLine($"Czas StringBuilder: {stopwatch.ElapsedMilliseconds}");


            Console.WriteLine(t1.Equals(t2));
        }

        static string CreateStringByAdd(int n)
        {
            string s = "";
            for (int i = 0; i < n; i++)
            {
                s += "A";
            }
            return s;
        }

        static string CreateStringByStringBuilder(int n)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append("A");
            }
            return sb.ToString();
        }
    }
}
