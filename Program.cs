using System;

namespace Proj
{
        class Program
    {
        static int factorial(int i)
        {
            int result;

            if (i == 1)
                return 1;
            result = factorial(i - 1) * i;
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
