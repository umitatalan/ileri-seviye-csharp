using System;
using System.Collections.Generic;

namespace ileri_seviye_csharp
{
    class Program
    {

        static void Main(string[] args)
        {
            Kisi ilkkisi = new Kisi("ABC", "XYZ", 37);
            ilkkisi.OzellikleriYaz();

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
