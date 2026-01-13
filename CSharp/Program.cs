using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================= DATA TYPE ========================");
            int myNum = 100000;
            Console.WriteLine(myNum);

            long myNumLong = 15000000000L;
            Console.WriteLine(myNumLong);

            float myFloat = 5.75F;
            Console.WriteLine(myFloat);

            double myDouble = 19.99D;
            Console.WriteLine(myDouble);

            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);

            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);
            Console.WriteLine(isFishTasty);

            char myGrade = 'B';
            Console.WriteLine(myGrade);

            string greeting = "Hello World";
            Console.WriteLine(greeting);
        }
    }
}