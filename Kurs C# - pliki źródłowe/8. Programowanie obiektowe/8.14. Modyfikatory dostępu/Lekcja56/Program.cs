using System;

namespace Lekcja56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();       
        }
    }

    public class A
    {
        // int defaultVar; == private

        private int privateVar;
        protected int protectedVar;
        internal int internalVar;
        public int publicVar;

        protected internal int protectedInternalVar;
        private protected int privateProtectedVar;

        void Test()
        {
            
        }
    }

    class B : A
    {
        void Test()
        {
            
        }
    }
}
