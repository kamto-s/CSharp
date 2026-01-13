using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================= TYPE CASTING ========================");
            int myInt = 10;
            double myDouble = myInt;

            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);

            Console.WriteLine("===============================================");

            double myDouble2 = 9.78;
            int myInt2 = (int)myDouble2;

            Console.WriteLine(myDouble2);
            Console.WriteLine(myInt2);

            Console.WriteLine("===============================================");
            int myInt3 = 9;
            double myDouble3 = 4.25;
            bool myBool = false;

            Console.WriteLine(Convert.ToString(myInt3));
            Console.WriteLine(Convert.ToDouble(myInt3));
            Console.WriteLine(Convert.ToInt32(myDouble3));
            Console.WriteLine(Convert.ToString(myBool));
        }
    }
}