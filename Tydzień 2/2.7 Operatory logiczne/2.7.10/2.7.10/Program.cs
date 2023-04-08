using System;
using System.Collections.Generic;
using System.Globalization;

namespace BuildingTriangle
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program sprawdza czy z podanych boków można zbudować trójkąt.");


            Console.WriteLine("Podaj długość pierwszego boku.");
            float sideA = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);

            Console.WriteLine("Podaj długość drugiego boku.");
            float sideB = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);

            Console.WriteLine("Podaj długość trzeciego boku.");
            float sideC = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);


            float longestSide = (sideA < sideB ? (sideB < sideC ? sideC : sideB) : (sideA < sideC ? sideC : sideA));

            if ((longestSide == sideA && sideB + sideC > longestSide) || 
                (longestSide == sideB && sideC + sideA > longestSide) || 
                (longestSide == sideC && sideA + sideB > longestSide))
            {
                Console.WriteLine("Z podanych boków można zbudować trójkąt.");
            }
            else
            {
                Console.WriteLine("Z podanych boków nie można zbudować trójkąta.");
            }

        }
    }
}