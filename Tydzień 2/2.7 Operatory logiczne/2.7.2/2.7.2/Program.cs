using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace EvenOrOdd
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program sprawdza czy liczba jest parzysta czy nieparzysta.");
            Console.WriteLine("Podal liczbę:");
            string a = Console.ReadLine();

            float number = float.Parse(a, CultureInfo.InvariantCulture.NumberFormat);
            //Int32.TryParse(a, out int number);

            if (number != (int)number)
            {
                Console.WriteLine("Podana liczba nie jest całkowita.");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine("Podana liczba jest parzysta.");
            }
            else
            {
                Console.WriteLine("Podana liczba jest nieparzysta.");
            }
        } 
    }
}
