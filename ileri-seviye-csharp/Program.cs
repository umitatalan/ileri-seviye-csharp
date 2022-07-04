using System;
using System.Collections.Generic;

namespace ileri_seviye_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5] { 1,2,3,4,5 };

            List<int> numbers = new List<int>(sayilar);
            numbers.Add(21);
            numbers.Add(1);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----");

            numbers.Remove(4);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Dizi uzunluğu : " + numbers.Count);
            Console.WriteLine(numbers.BinarySearch(21));
            Console.WriteLine(numbers[5]);

            Console.ReadLine();
        }
    }
}
