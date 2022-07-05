using System;
using System.Collections.Generic;

namespace ileri_seviye_csharp
{
    class Program
    {

        static void Main(string[] args)
        {
            //Enums
            Person person = new Person(Schools.YüksekOkul);

            if (person.school.Equals(Schools.Lise))
            {
                Console.WriteLine("ABC");
            }
            else if (person.school.Equals(Schools.YüksekOkul))
            {
                Console.WriteLine("DEF");
            }
            else if (person.school.Equals(Schools.Lisans))
            {
                Console.WriteLine("GHİ");
            }

            Console.WriteLine((int)Schools.Lisans);

            Console.WriteLine(Enum.Parse(typeof(Schools), "0"));

            Console.WriteLine(Enum.GetName(typeof(Schools), 1));

            string[] scholls = Enum.GetNames(typeof(Schools));

            foreach (var item in scholls)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        class Person
        {
            public Schools school;

            public Person(Schools school)
            {
                this.school = school;
            }
        }

        enum Schools
        {
            Lise, YüksekOkul, Lisans
        }
    }
}
