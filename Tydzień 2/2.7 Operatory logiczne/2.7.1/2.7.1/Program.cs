using System;
using System.ComponentModel.Design;

namespace EqualNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;

            if (a == b)
            {
                Console.WriteLine("Liczby są równe.");
            }
            else
            {
                Console.WriteLine("Liczbą nie są równe.");
            }
        }
    }
}