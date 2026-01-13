using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================= User Input ========================");
           
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, " + name);
            Console.WriteLine("Your age is " + age);

            Console.WriteLine("===============================================");
        }
    }
}