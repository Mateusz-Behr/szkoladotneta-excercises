using System;
using System.Diagnostics.Metrics;

namespace PrimeNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program sprawdza ile jest liczb pierwszych w zakresie 0 - 100");
            
            int counter = 0;
            for (int number = 2; number <= 100; number++)
            {
                bool isPrime = true;
                for (int divisor = 2; divisor <= number / 2; divisor++)
                {
                    if (number % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    counter++;
                }

            }
            Console.WriteLine($"W przedziale 0 - 100 jest {counter} liczb pierwszych.");
        }
    }
}
 