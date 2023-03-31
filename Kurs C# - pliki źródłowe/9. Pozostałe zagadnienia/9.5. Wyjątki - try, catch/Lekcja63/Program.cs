using System;

namespace Lekcja63
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[1];

            try
            {
                int y = int.Parse("ABC");
                int x = 2 / int.Parse("0");
                nums[1] = 2;
                Console.WriteLine("Przerywa");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Wykona się i tak");
            }

            Console.WriteLine("Nie przerywa");
        }
    }
}
