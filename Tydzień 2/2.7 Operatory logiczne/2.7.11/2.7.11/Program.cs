using System;

namespace SchoolGrade
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program zmienia ocenę ucznia na jej opis.");
            Console.WriteLine("Podaję ocenę w skali 1 - 6.");

            int grade = int.Parse(Console.ReadLine());

            string gradeName = grade switch
            {
                6 => "Celujący",
                5 => "Bardzo dobry",
                4 => "Dobry",
                3 => "Dostateczny",
                2 => "Dopuszczający",
                1 => "Niedostateczny",
                _ => "Podałeś niewłaściwą ocenę."
            };

            Console.WriteLine($"{gradeName}");

        }
    }
}