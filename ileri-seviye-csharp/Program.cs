using System;
using System.Collections.Generic;

namespace ileri_seviye_csharp
{
    class Program
    {

        static void Main(string[] args)
        {
            //public : Her yerden ulaşılabilir.
            //private : özeldir. Sadece sınıf içerisinden ulaşılabilir.
            //internal : Aynı namespace'de ulaşılabilir.


            Console.ReadLine();
        }
    }

    class Sinif
    {
        public int x = 1;

        public void yazdir(string text)
        {
            Console.WriteLine(text);
        }
    }
}
