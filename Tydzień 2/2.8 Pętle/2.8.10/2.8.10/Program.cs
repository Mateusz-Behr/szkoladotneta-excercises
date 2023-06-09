﻿using System;

namespace LeastCommonMultiple
{
    public class Program
    {
        static void Main()
        {
            int a, b, remainder, gCD, lCM, inputtedA, inputtedB; // gCD - Greatest Common Divisor; lCM - Least Common Multiple //
            Console.WriteLine("Program znajduje najmniejszą wspólną wielokrotność (NWW) dwóch liczb naturalnych.");

            do
            {
                Console.WriteLine("Podaj pierwszą liczbę: ");
                int.TryParse(Console.ReadLine(), out inputtedA);

                Console.WriteLine("Podaj drugą liczbę: ");
                int.TryParse(Console.ReadLine(), out inputtedB);

                if (inputtedA <= 0 || inputtedB <= 0)
                {
                    Console.WriteLine("Należy podać dwie liczby naturalne.");
                }
            }
            while (inputtedA <= 0 && inputtedB <= 0 || inputtedA > 0 && inputtedB <= 0 || inputtedA <= 0 && inputtedB > 0);

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