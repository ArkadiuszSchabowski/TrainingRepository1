using System;

namespace Lekcja11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rzutowanie

            int varInt = 2000;
            long varLong;

            varLong = (long)varInt;
            Console.WriteLine(varLong);

            short varShort;
            varShort = (short)varInt;
            Console.WriteLine(varShort);

            float varFloat = 5.99f;
            varLong = (long)varFloat;
            Console.WriteLine(varLong);

            varFloat = varInt;
            Console.WriteLine(varFloat);

            string tekst = "123";
            varInt = (int)(object)tekst;
            Console.WriteLine(varInt);
        }
    }
}
