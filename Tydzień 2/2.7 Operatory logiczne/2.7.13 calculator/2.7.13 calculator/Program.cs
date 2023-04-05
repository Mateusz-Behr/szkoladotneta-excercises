using System;
using System.Globalization;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulator liczy proste działania na dwóch liczbach.");

            Console.WriteLine("Podaj pierwszą liczbę.");
            float numberA = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);

            Console.WriteLine("Podaj drugą liczbę.");
            float numberB = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);

            Console.WriteLine(@"Podaj numer operacji do wykonania:
        1. Dodawanie
        2. Odejmowanie
        3. Mnożenie
        4. Dzielenie");

            int mathOperation = int.Parse(Console.ReadLine());

            
            switch (mathOperation)
            {
                case 1:
                    float addition = numberA + numberB;
                    Console.WriteLine($"Wynik: {Math.Round(addition, 3)}");       
                    break;
                case 2:
                    float subtraction = numberA - numberB;
                    Console.WriteLine($"Wynik: {Math.Round(subtraction, 3)}");
                    break;
                case 3:
                    float multiplication = numberA * numberB;
                    Console.WriteLine($"Wynik: {Math.Round(multiplication, 3)}");
                    break;
                case 4:
                    float division = numberA / numberB;
                    Console.WriteLine($"Wynik: {Math.Round(division, 3)}");
                    break;
                default:
                    Console.WriteLine("Błąd, wybierz operację 1 - 4.");
                    break;
            }
        }
    }
}