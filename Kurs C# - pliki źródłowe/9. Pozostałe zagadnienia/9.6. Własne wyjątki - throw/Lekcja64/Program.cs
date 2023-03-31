using System;

namespace Lekcja64
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Silnia(-5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static int Silnia(int n)
        {
            if (n < 0)
            {
                throw new SilniaException();
            }
            else if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Silnia(n - 1);
            }
        }
    }

    class SilniaException : Exception
    {
        public override string Message
        {
            get { return "Wyjątek klasy Silnia."; }
        }
    }
}
