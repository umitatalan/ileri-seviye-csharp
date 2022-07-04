using System;

namespace ileri_seviye_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // var işleci verinin tipinin belli olmadığı durumlarda kullanılır.

            //object bütün sınıfların temel sınıfıdır.

            object x = 5;
            object y = "merhaba";

            string mesaj = (string)y;
            Console.WriteLine(mesaj);

            //dynamic geliştirme aşamasında hata göstermez ancak çalışma anında hata verir. Dinamik programlamaya imkan verir.a

            dynamic kelime = "merhaba";
            Console.WriteLine(kelime.ToUpper());


            Console.ReadLine();
        }
    }
}
