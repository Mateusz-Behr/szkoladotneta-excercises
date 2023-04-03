using System;
using System.Globalization;

namespace Temperature
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program zwraca ocenę temperatury powietrza wprowadzonej przez użytkownika.");

            Console.WriteLine("Podaj wartość temperatury na zewnątrz.");
            float temp = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);

            if (temp < 0)
            {
                Console.WriteLine("Cholernie piździ.");
            }
            else if (temp < 10)
            {
                Console.WriteLine("Zimno.");
            }
            else if (temp < 20)
            {
                Console.WriteLine("Chłodno.");
            }
            else if (temp < 30)
            {
                Console.WriteLine("W sam raz.");
            }
            else if (temp < 40)
            {
                Console.WriteLine("Zaczyna być słabo, bo gorąco.");
            }
            else
            {
                Console.WriteLine("A weź, wyprowadzam się na Alaskę.");
            }
        }
    }
}