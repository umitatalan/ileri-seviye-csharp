using System;
using System.Collections.Generic;

namespace ileri_seviye_csharp
{
    class Program
    {

        static void Main(string[] args)
        {
            //Overloading

            Console.WriteLine(topla(5,1));
            Console.WriteLine(topla(1,7,3));
            Console.WriteLine(topla(5.3,5.9));

            yazdir(5);
            yazdir("Text");

            Console.ReadLine();
        }

        static int topla(int a, int b)
        {
            return a + b;
        }

        static int topla(int a, int b, int c)
        {
            return a + b + c;
        }
        
        static double topla(double a, double b)
        {
            return a + b;
        }
        
        static void yazdir(int sayi)
        {
            Console.WriteLine(sayi.ToString());
        }

        static void yazdir(string metin)
        {
            Console.WriteLine(metin);
        }


    }
}
