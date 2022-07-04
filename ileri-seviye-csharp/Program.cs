using System;

namespace ileri_seviye_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] dizi = { { -1, 7 }, { 5, 1 }, { 9, -8 } };
            Console.WriteLine(dizi[2, 1]);

            int[,,] dizi2 = { { { 1, 5 }, { 5, 9 }, { 1, -1 } }, { { -2, 2 }, { 4, -4 }, { 9, 0 } } };
            Console.WriteLine(dizi2[1, 1, 1]);

            Console.ReadLine();
        }
    }
}
