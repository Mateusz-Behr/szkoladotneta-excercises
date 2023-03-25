using System;
using System.Collections.Generic;
using System.Text;

namespace Variables
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj, proszę podaj swoje dane:");
            Console.WriteLine("Imię:");

            string firstName = Console.ReadLine();

            Console.WriteLine("Nazwisko:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Wiek:");
            string enteredAge = Console.ReadLine();

            int age = 0;
            Int32.TryParse(enteredAge, out age);

            Console.WriteLine("Płeć (m/k):");

            string enteredGender = Console.ReadLine();
            char gender = char.Parse(enteredGender);

            Console.WriteLine("PESEL:");
            string enteredPesel = Console.ReadLine();

            Console.WriteLine("Numer pracownika:");
            string emplNumber = Console.ReadLine();

            long employeeNumber = long.Parse(emplNumber);
            Int64.TryParse(emplNumber, out employeeNumber);

            Console.Write($"Wpisane dane: \r\n" +
                $"Imię: {firstName}\r\n" +
                $"Nazwisko: {lastName}\r\n" +
                $"Wiek: {age}\r\n" +
                $"Płeć: {gender}\r\n" +
                $"PESEL: {enteredPesel}\r\n" +
                $"Nr pracownika: {employeeNumber}");

        }
    }
}