using System;

namespace Lekcja47
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test(2);
            Test test2 = new Test(10);
            //test.varReadonly = 2;
            //Test.varConst = 2;
            Console.WriteLine(Test.varReadonly);
            Console.WriteLine(Test.varConst);
        }
    }

    class Test
    {
        static Test()
        {
            varReadonly = 2;
            //varConst = 2;
        }

        public Test(int n)
        {
            //varConst = n;
            //varReadonly = n;
        }

        public const int varConst = 1;
        public static readonly int varReadonly;


        static void Change()
        {
            //varConst = 2;
            //varReadonly = 2;
        }
    }
}
