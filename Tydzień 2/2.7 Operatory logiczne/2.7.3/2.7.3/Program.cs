using System;
using System.Globalization;

namespace PositiveNegative
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program sprawdza czy liczba jest dodatnia czy ujemna");
            Console.WriteLine("Podaj liczbę");

            string a = Console.ReadLine();
            float number = float.Parse(a, CultureInfo.InvariantCulture.NumberFormat);

            if (number < 0)
            {
                Console.WriteLine("Podana liczba jest ujemna");
            }
            else if (number > 0)
            {
                Console.WriteLine("Podana liczba jest dodatnia");
            }
            else 
            { 
                Console.WriteLine("Zero nie jest ani dodatnie, ani ujemne."); 
            }
        }
    }
}
