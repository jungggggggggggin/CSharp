using System;
namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
                Console.WriteLine("2 ^ {0,2} = {1, 7}", i, Power(2, i));
        }
        private static int Power(int v, int i)
        {
            int p = 1;
            for (int i = 1; i <= m; i++)
                p *= n;
            return p;
        }
    }
}
