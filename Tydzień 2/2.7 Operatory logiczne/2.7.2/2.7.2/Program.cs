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
            Console.WriteLine("Podaj liczbę:");

            float number = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);

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
