using System;


namespace Statement
{
    class CompoundStApp
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter one digit = ");
            n = Console.Read() - '0';
            if (n < 0)
                Console.WriteLine("Negative number !");
            else
            {
                Console.WriteLine(n + " squared is " + (n * n));
                Console.WriteLine(n + " cubed is " + (n * n * n));
            }
        }
    }
}
