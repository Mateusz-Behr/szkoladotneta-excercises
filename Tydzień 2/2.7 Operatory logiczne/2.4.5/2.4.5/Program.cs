using System;
using System.Globalization;

namespace MemberOfParliament
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program sprawdza czy w danym wieku można zostać posłem.");
            Console.WriteLine("Podaj wiek");

            string a = Console.ReadLine();
            float age = float.Parse(a, CultureInfo.InvariantCulture.NumberFormat);

            if (age >= 21)
            {
                Console.WriteLine("Możesz zostać posłem.");
            }
            else
            {
                Console.WriteLine("Jeszcze nie możesz zostać posłem.");
            }
        }
    }
}