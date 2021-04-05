using System;


namespace Statement
{
    class IfStApp
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter a number = ");
            n = Console.Read() - '0';
            if (n % 2 == 0)
                Console.WriteLine(n + " is an even number.");
            if (n % 2 != 0)
                Console.WriteLine(n + " is an odd number.");
        }
    }
}
