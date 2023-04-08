using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulator liczy proste działania na dwóch liczbach.");

            Console.WriteLine("Podaj pierwszą liczbę.");
            decimal numberA = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);

            Console.WriteLine("Podaj drugą liczbę.");
            decimal numberB = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);

            Console.WriteLine(@"Podaj numer operacji do wykonania:
        1. Dodawanie
        2. Odejmowanie
        3. Mnożenie
        4. Dzielenie");
            
            int.TryParse(Console.ReadLine(), out int mathOperation);
            
            switch (mathOperation)
            {
                case 1:
                    Console.WriteLine($"Wynik: {numberA + numberB}");
                    break;
                case 2:
                    Console.WriteLine($"Wynik: {numberA - numberB}");
                    break;
                case 3:
                    Console.WriteLine($"Wynik: {numberA * numberB}");
                    break;
                case 4:
                    try
                    {
                        Console.WriteLine($"Wynik: {numberA / numberB}");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Nie można dzielić przez zero.");
                    }
                    break;
                default:
                    Console.WriteLine("Błąd, wybierz operację 1 - 4.");
                    break;
            }
        }
    }
}