using System;


namespace Statement
{
    class SimpleIOApp
    {
        static void Main(string[] args)
        {
            int i; char c;
            Console.Write("Enter a digit and a character = ");
            i = Console.Read() - 48;
            c = (char)Console.Read();
            Console.Write("i = " + i);
            Console.WriteLine(", c = " + c);
        }
    }
}
