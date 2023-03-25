using System;
using System.Globalization;

namespace RectangleDiagonal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program wyznacza długość przeciprostokątnej trójkąta.");
            Console.WriteLine("Podaj długość boku a.");
            string strLengthA = Console.ReadLine();

            float lengthA = float.Parse(strLengthA, CultureInfo.InvariantCulture.NumberFormat);

            Console.WriteLine("Podaj długość boku b.");
            string strLengthB = Console.ReadLine();

            float lengthB = float.Parse(strLengthB, CultureInfo.InvariantCulture.NumberFormat);


            double lengthRaisedC = (Math.Pow(lengthB, 2) + Math.Pow(lengthA, 2));
            double lengthC = Math.Sqrt(lengthRaisedC);

            Console.WriteLine($"Długość boku c wynosi: {Math.Round(lengthC, 2)}");

        }
    }
}