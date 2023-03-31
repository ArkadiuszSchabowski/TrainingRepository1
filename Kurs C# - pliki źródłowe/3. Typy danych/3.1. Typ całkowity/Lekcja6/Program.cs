using System;

namespace Lekcja6
{
    class Program
    {
        static void Main(string[] args)
        {
            // TYPY DANYCH [Liczby całkowite]

            byte varByte = 100;
            Console.WriteLine(varByte);
            Console.WriteLine($"Byte min: {byte.MinValue}, max: {byte.MaxValue}");
            
            short varShort = 3000;
            Console.WriteLine($"Short min: {short.MinValue}, max: {short.MaxValue}");

            int varInt = 300000;
            Console.WriteLine($"Int min: {int.MinValue}, max: {int.MaxValue}");

            long varLong = 300000000;
            Console.WriteLine($"Long min: {long.MinValue}, max: {long.MaxValue}");

            Console.WriteLine();
            uint varUInt = 100;

            sbyte varSByte = -100;
            Console.WriteLine($"SByte min: {sbyte.MinValue}, max: {sbyte.MaxValue}");

            Console.WriteLine($"UShort min: {ushort.MinValue}, max: {ushort.MaxValue}");
            Console.WriteLine($"UInt min: {uint.MinValue}, max: {uint.MaxValue}");
            Console.WriteLine($"ULong min: {ulong.MinValue}, max: {ulong.MaxValue}");

            // int liczba = 101.50; - BŁĄD
        }
    }
}
