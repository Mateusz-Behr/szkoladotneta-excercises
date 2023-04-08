using System;
using System.Globalization;

namespace MemberOfParliament
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program sprawdza czy w danym wieku można zostać posłem, senatorem i prezydentem.");
            Console.WriteLine("Podaj wiek");

            string a = Console.ReadLine();
            float age = float.Parse(a, CultureInfo.InvariantCulture.NumberFormat);

            if (age < 21)
            {
                Console.WriteLine("Jeszcze nie możesz zostać posłem.");
            }
            else if (age < 30)
            {
                Console.WriteLine("Możesz zostać posłem.");
            }
            else if (age < 35)
            {
                Console.WriteLine("Możesz zostać posłem i senatorem.");
            }
            else
            {
                Console.WriteLine("Możesz zostać posłem, senatorem i prezydentem.");
            }
        }
    }
}