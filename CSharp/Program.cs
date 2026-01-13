using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================= VARIABLES ========================");
            string name = "Jhonny";
            Console.WriteLine(name);

            int myNum = 15;
            myNum = 20;
            Console.WriteLine(myNum);

            double myDouble = 19.99;
            Console.WriteLine(myDouble);

            char myChar = 'D';
            Console.WriteLine(myChar);

            bool myBool = true;
            Console.WriteLine(myBool);

            Console.WriteLine("Hello World!");

            Console.WriteLine("======================= VARIABLES CONST ========================");
            const int myConstNum = 10;
            Console.WriteLine(myConstNum);

            Console.WriteLine("======================= VARIABLES DISPLAY ========================");
            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            int x = 5;
            int y = 4;
            int z = x + y;
            Console.WriteLine(z);

            Console.WriteLine("========================= Multiple Variables ======================");
            int a, b, c;
            a = b = c = 50;
            Console.WriteLine(a + b + c);


        }
    }
}