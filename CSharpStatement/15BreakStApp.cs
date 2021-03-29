using System;


namespace Statement
{
    class BreakStApp
    {
        static void Main(string[] args)
        {
            int n, i;
            double h = 0.0;
            Console.Write("Enter a number = ");
            n = Console.Read() - '0';
            i = 1;
            while (true)
            {
                h = h + 1 / (double)i;
                if (++i > n) break;
            }
            Console.WriteLine(" n = " + n + ", h = " + h);
        }
    }
}
