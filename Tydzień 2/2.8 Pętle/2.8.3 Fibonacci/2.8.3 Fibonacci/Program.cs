﻿using System;

namespace FibonacciSequence
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Ile liczb ciągu Fibonacciego chcesz wyświetlić?");

            int sequenceLength = int.Parse(Console.ReadLine());

            long prevNumber = -1;
            long nextNumber = 1;

            for (int i = 0; i < sequenceLength; i++)
            {
                long sum = prevNumber + nextNumber;

                prevNumber = nextNumber;
                nextNumber = sum;

                Console.WriteLine($"F{i} = {sum}");
            }
        }
    }
}