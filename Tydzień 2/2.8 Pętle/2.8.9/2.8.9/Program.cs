using System;

namespace DecimalToBinary
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Program zamienię liczbę dziesiętną podaną przez użytkownika na liczbę binarną.");
            Console.WriteLine("Podaj liczbę dziesiętną: ");

            int.TryParse(Console.ReadLine(), out int decimalNumber);
            int remainder;
            string binaryNumber = string.Empty;

            while (decimalNumber > 0 || string.IsNullOrEmpty(binaryNumber))
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;

                binaryNumber = remainder + binaryNumber;
            }

            Console.WriteLine($"Postać binarna: {binaryNumber}");
        }
    }
}