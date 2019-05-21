using System;
using System.IO;
using System.Runtime.Serialization.XmlObjectSerializer;

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
            Console.WriteLine("Hi guys!");
            System.Console.WriteLine("Shehurin");

        }
    }

}
