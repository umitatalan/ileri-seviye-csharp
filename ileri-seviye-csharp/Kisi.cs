using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ileri_seviye_csharp
{
    class Kisi
    {
        public string Ad;
        public string Soyad;
        public int Yas;

        public void OzellikleriYaz()
        {
            Console.WriteLine("{0}\n{1}\n{2}", Ad, Soyad, Yas);
        }
    }
}
