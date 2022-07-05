using System;
using System.Collections.Generic;

namespace ileri_seviye_csharp
{
    class Program
    {

        static void Main(string[] args)
        {
            Sinif sinif = new Sinif();
            Console.WriteLine(sinif.x);
            sinif.yazdir("Merhaba");

            Kisi kisi1 = new Kisi();
            kisi1.Ad = "Ahmet";
            kisi1.Soyad = "Mehmet";
            kisi1.Yas = 39;
            kisi1.OzellikleriYaz();

            Kisi kisi2 = new Kisi() { Ad = "Mehmet", Soyad = "Alnıaçık", Yas = 41 };
            kisi2.OzellikleriYaz();

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
