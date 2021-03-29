using System;


namespace Statement
{
    class DoWhileStApp
    {
        static void Main(string[] args)
        {
            int n, i;
            double h = 0.0;
            Console.Write("Enter a number = ");
            n = Console.Read() - '0';
            i = 1;
            do
            {
                h = h + 1 / (double)i;
                i++;
            } while (i <= n);
            Console.WriteLine("n = " + n + ", h = " + h);
        }
    }
}
