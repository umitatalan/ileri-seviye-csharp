using System;
using System.Collections.Generic;

namespace ileri_seviye_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // params anahtar sözcüğü
            Console.WriteLine(topla(1,5,6, 8,9,11,-6,44, 51));
            Console.ReadLine();
        }

        static int topla(params int[] sayilar)
        {
            int toplam = 0;

            foreach (var item in sayilar)
            {
                toplam += item;
            }

            return toplam;
        }
    }
}
