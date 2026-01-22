using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================= Operators ========================");

            int angka1;
            Console.WriteLine("Tulis angka pertama: ");
            while (!int.TryParse(Console.ReadLine(), out angka1))
            {
                Console.WriteLine("Input tidak valid, coba lagi");
                Console.WriteLine("Tulis angka pertama: ");
            }

            int angka2;
            Console.WriteLine("Tulis angka kedua: ");
            while (!int.TryParse(Console.ReadLine(), out angka2))
            {
                Console.WriteLine("Input tidak valid, coba lagi");
                Console.WriteLine("Tulis angka kedua: ");
            }

            Console.WriteLine("===================== Hasil ========================");
            Console.WriteLine("Penjumlahan: " + (angka1 + angka2));
            Console.WriteLine("Pengurangan: " + (angka1 - angka2));
            Console.WriteLine("Perkalian: " + (angka1 * angka2));
            Console.WriteLine("Pembagian: " + ((double)angka1 / angka2));
        }
    }
}