using System;
using System.Runtime.CompilerServices;

namespace MaxFromThreeNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program podaje największą liczbę całkowitą z trzech podanych przez użytkownika.");

            Console.WriteLine("Podaj pierwszą liczbę.");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbą.");
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj trzecią liczbę.");
            int third = int.Parse(Console.ReadLine());

            int result = (first < second ? (second < third ? third : second) : (first < third ? third : first));

            Console.WriteLine($"Największą liczbą jest: {result}");
        }
    }
}