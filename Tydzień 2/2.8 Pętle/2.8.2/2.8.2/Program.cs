using System;

namespace EvenNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 0;

            Console.WriteLine("Program znajduje wszystkie liczby parzyste z zakresu 0 - 1000");

            do
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine($"{a}");
                }

                a++;
            }
            while (a <= 1000);
        }
    }
}