using System;

namespace ReversingString
{
    public class Program
    {
        static void Main(string[] args)
        {
            string reversedString = string.Empty;

            Console.WriteLine("Program odwraca ciąg znaków wprowadzony przez użytkownika.");

            Console.Write("Wpisz dowolny ciąg znaków: ");

            string inputtedString = Console.ReadLine();

            for (int i = inputtedString.Length - 1; i >= 0; i--)
            {
                reversedString += inputtedString[i];
            }
            Console.WriteLine($"Odwrócony ciąg: {reversedString}");
        }
    }
}