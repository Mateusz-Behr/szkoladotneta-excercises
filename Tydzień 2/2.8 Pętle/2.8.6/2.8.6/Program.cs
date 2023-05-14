using System;

namespace StringSum
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Program wypisuje sumę 20 liczb wg wzoru 1/1 + 1/2 + 1/3...");
            float sum = 0;

            for (float i = 1; i <= 20; i++)
            {
                sum += (1 / i);
            }
            Console.WriteLine(sum);
        }
    }
}