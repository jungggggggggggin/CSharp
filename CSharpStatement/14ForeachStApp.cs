using System;


namespace Statement
{
    class ForeachStApp
    {
        static void Main(string[] args)
        {
            string[] color = { "red", "green", "blue" };
            foreach (string s in color)
                Console.WriteLine(s);
        }
    }
}
