using System;
using System.Data;

namespace PyramidOfNumbers
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Program wyświetla piramidę liczb od 1 do podanej przez użytkownika");
            Console.WriteLine("Ile liczb ma się znaleźć w piramidzie?");

            int pyramidSize = int.Parse(Console.ReadLine());
            int row = 1;
            int pos = 1;

            for (int i = 1; i <= pyramidSize; i++)
            {
                if (pos <= row)
                {
                    Console.Write($"{i} ");
                    pos++;
                }
                else
                {
                    Console.Write("\n");
                    row++;
                    pos = 1;
                    i--;
                }
            }
        }
    }
}