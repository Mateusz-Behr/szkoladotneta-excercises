using System;

namespace IsLeapYear
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program sprawdza czy podany rok jest przestępny.");
            Console.WriteLine("Podaj rok");

            string a = Console.ReadLine();

            Int32.TryParse(a, out int year);

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("Podany rok jest rokiem przestępnym.");
            }
            else
            {
                Console.WriteLine("Podany rok nie jest rokiem przestępnym.");
            }
        }
    }
}