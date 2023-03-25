using System;

namespace Variables2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char var1 = 'a';
            char var2 = 'b';
            char var3 = 'c';

            char[] chars = { var3, var2, var1 };
            Console.WriteLine(chars);

            Console.WriteLine(var3);
            Console.WriteLine(var2);
            Console.WriteLine(var1);

        }
    }
}