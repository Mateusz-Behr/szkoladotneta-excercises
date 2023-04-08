using System;
using System.Globalization;

namespace Height
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program ocenia podaną wysokość ciała użytkownika (mężczyzny) na podstawie danych statystycznych.");
            Console.WriteLine("Podaj swoją wysokość ciała w centymetrach.");

            float height = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
            
            if (height < 154)
            {
                Console.WriteLine("Jesteś skrajnie niski.");
            }
            else if (height < 161)
            {
                Console.WriteLine("Jesteś bardzo niski.");
            }
            else if (height < 168)
            {
                Console.WriteLine("Jesteś niski.");
            }
            else if (height < 182)
            {
                Console.WriteLine("Jesteś przeciętnego wzrostu.");
            }
            else if (height < 189)
            {
                Console.WriteLine("Jesteś wysoki.");
            }
            else if (height < 196)
            {
                Console.WriteLine("Jesteś bardzo wysoki.");
            }
            else
            {
                Console.WriteLine("Jesteś skrajnie wysoki.");
            }
        }
    }
}
