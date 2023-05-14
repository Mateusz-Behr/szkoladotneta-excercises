using System;

namespace Exponentation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program wypisuje wszystkie sześciany liczb 1 - 20.");
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            for (int i = 1; i <= 20;  i++)
            {
                Console.WriteLine($"{i}\xB3 = {Math.Pow(i, 3)}");
            }
        }
    }
}