using System;

namespace LeastCommonMultiple
{
    public class Program
    {
        static void Main()
        {
            int a, b, remainder, gCD, lCM; //gCD - Greatest Common Divisor; lCM - Least Common Multiple//
            Console.WriteLine("Program znajduje najmniejszą wspólną wielokrotność (NWW) dwóch liczb naturalnych.");

            Inputting:
            Console.WriteLine("Podaj pierwszą liczbę: ");
            int inputtedA = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę: ");
            int inputtedB = int.Parse(Console.ReadLine());

            if (inputtedA <= 0 || inputtedB <= 0)
            {
                Console.WriteLine("Należy podać dwie liczby naturalne.");
                goto Inputting;
            }

            if (inputtedA >= inputtedB)
            {
                a = inputtedA;
                b = inputtedB;
            }
            else
            {
                a = inputtedB;
                b = inputtedA;
            }

            remainder = a % b;

            while (remainder != 0)
            {
                a = b;
                b = remainder;
                remainder = a % b;
            }
            gCD = b;
            lCM = inputtedA * inputtedB / gCD;

            Console.WriteLine($"Najmniejsza wspólna wielokrotoność liczb {inputtedA} i {inputtedB} wynosi {lCM}.");

        }
    }
}