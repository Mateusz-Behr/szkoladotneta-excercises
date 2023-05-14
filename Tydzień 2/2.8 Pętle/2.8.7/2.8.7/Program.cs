using System;
using System.Globalization;

namespace Diamond
{
    public class Program
    {
        static void Main(string[] args)
        {
            int size, space, i, j;
            Console.WriteLine("Program rysuje diament złożony z symboli *, o wielkości podanej przez użytkownika.");
            Console.WriteLine("Podaj długość krótszej przekątnej.");

            int diagonal = int.Parse(Console.ReadLine());

            size = diagonal % 2 == 1 ? (diagonal + 1) / 2 : diagonal / 2;

            space = size - 1;

            Console.WriteLine();

            for (i = 1; i <= size; i++)
            {
                for (j = 1; j <= space; j++)
                    Console.Write(" ");
                space--;

                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");

                Console.WriteLine();
            }
            
            space = diagonal % 2 == 1 ? 1 : 0;

            for (i = 1; i <= (diagonal % 2 == 1 ? size - 1 : size); i++)
            {
                
                for (j = 1; j <= space; j++)
                    Console.Write(" ");

                space++;

                for (j = 1; j <= (diagonal % 2 == 1 ? 2 * (size - i) - 1 : 2 * (size - i) + 1); j++)
                    Console.Write("*");

                Console.WriteLine();
            }   
        }
    }
}