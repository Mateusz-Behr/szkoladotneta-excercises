using System;
using System.Text;

namespace ReversingString
{
    public class Program
    {
        static void Main(string[] args)
        {
            StringBuilder reversedString = new StringBuilder();

            Console.WriteLine("Program odwraca ciąg znaków wprowadzony przez użytkownika.");

            Console.Write("Wpisz dowolny ciąg znaków: ");
            string inputtedString = Console.ReadLine();

            for (int i = inputtedString.Length - 1; i >= 0; i--)
            {
                reversedString.Append(inputtedString[i]);
            }

            Console.WriteLine($"Odwrócony ciąg: {reversedString}");
        }
    }
}