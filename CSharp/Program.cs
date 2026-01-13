using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================= Operators ========================");

            int x = 10 + 50;
            Console.WriteLine(x);

            Console.WriteLine("===============================================");

            int sum1 = 100 + 50;
            int sum2 = sum1 + 250;
            int sum3 = sum2 + sum2;

            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);

            Console.WriteLine("======================== Comparison Operators =======================");

            int a = 10;
            int b = 10;

            Console.WriteLine(a >= b);

            int xz = 10;
            int yz = 20;
            Console.WriteLine(xz != yz);
        }
    }
}