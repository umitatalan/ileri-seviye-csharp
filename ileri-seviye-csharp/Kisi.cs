using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ileri_seviye_csharp
{
    class Kisi
    {
        private string Ad;
        private string Soyad;
        private int Yas;

        public Kisi(string ad, string soyad, int yas)
        {
            Ad = ad;
            Soyad = soyad;
            Yas = yas;
        }

        public void OzellikleriYaz()
        {
            Console.WriteLine("{0}\n{1}\n{2}", Ad, Soyad, Yas);
        }
    }
}
