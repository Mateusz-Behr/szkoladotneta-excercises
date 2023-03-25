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

            Int32.TryParse(enteredAge, out int age);


            Console.WriteLine("Płeć (m/k):");
            string enteredGender = Console.ReadLine();

            char gender = char.Parse(enteredGender);


            Console.WriteLine("Wysokość ciała w cm:");
            string enteredHeight = Console.ReadLine();

            float height = float.Parse(enteredHeight);


            Console.WriteLine("Masa ciała w kg:");
            string enteredWeight = Console.ReadLine();

            float weight = float.Parse(enteredWeight);


            Console.WriteLine("Numer telefonu:");
            string enteredPhoneNumber = Console.ReadLine();

            int phoneNumber = int.Parse(enteredPhoneNumber);

            Console.WriteLine("Adres email:");
            string email = Console.ReadLine();


            Console.WriteLine("PESEL:");
            string pesel = Console.ReadLine();


            Console.WriteLine("Numer pracownika:");
            string emplNumber = Console.ReadLine();

            long employeeNumber = long.Parse(emplNumber);
            Int64.TryParse(emplNumber, out employeeNumber);
            
            Console.WriteLine("--------------------");
            Console.Write($"Wpisane dane: \r\n" +
                $"Imię: {firstName}\r\n" +
                $"Nazwisko: {lastName}\r\n" +
                $"Wiek: {age}\r\n" +
                $"Płeć: {gender}\r\n" +
                $"Wysokość ciała: {height} cm\r\n" +
                $"Masa ciała: {weight} kg\r\n" +
                $"Numer telefonu: {phoneNumber}\r\n" +
                $"Adres email: {email}\r\n" +
                $"PESEL: {pesel}\r\n" +
                $"Nr pracownika: {employeeNumber}\r\n" +
                "--------------------");

        }
    }
}