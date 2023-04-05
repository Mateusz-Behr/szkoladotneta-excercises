using System;

namespace WeekDays
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program pobiera numer dnia tygodnia i wyświetla jego nazwę.");
            Console.WriteLine("Podaj numer dnia tygodnia");

            int weekDayNumber = int.Parse(Console.ReadLine());

            string weekDayName = weekDayNumber switch
            {
                1 => "Poniedziałek",
                2 => "Wtorek",
                3 => "Środa",
                4 => "Czwartek",
                5 => "Piątek",
                6 => "Sobota",
                7 => "Niedziela",
                _ => "Błąd",
            };

            Console.WriteLine(weekDayName);

        }
    }
}