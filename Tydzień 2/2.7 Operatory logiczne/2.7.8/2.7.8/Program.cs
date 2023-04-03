using System;
using System.Globalization;

namespace StudiesRequirements
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program sprawdza czy kandydat może ubiegać się o miejsce na studiach.");

            Console.WriteLine("Podaj wynik matury z matematyki.");
            int mathGrade = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wynik matury z fizyki.");
            int physicsGrade = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wynik matury z chemii.");
            int chemistryGrade = int.Parse(Console.ReadLine());


            if ((mathGrade > 70 && physicsGrade > 55 && chemistryGrade > 45) && (mathGrade + physicsGrade + chemistryGrade > 180))
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji.");
            }
            else if ((mathGrade + physicsGrade) > 150 || (mathGrade + chemistryGrade) > 150)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji.");
            }
            else
            {
                Console.WriteLine("Kandydat nie dopuszczony do rekrutacji.");
            }
        }
    }
}