using System;


namespace Statement
{
    class CalculatorApp
    {
        static void Main(string[] args)
        {
            int x, y, r = 0;
            char opr;
            Console.Write("Enter an operator & two numbers = ");
            opr = (char)Console.Read();
            x = Console.Read() - '0';
            y = Console.Read() - '0';
            switch (opr)
            {
                case '+':
                    r = x + y;
                    Console.WriteLine(x + " + " + y + " = " + r); break;
                case '-':
                    r = x - y;
                    Console.WriteLine(x + " - " + y + " = " + r); break;
                case '*':
                    r = x * y;
                    Console.WriteLine(x + " * " + y + " = " + r); break;
                case '/':
                    r = x / y;
                    Console.WriteLine(x + " / " + y + " = " + r); break;
                default: Console.WriteLine("Illegal operator "); break;

            }
        }
    }
}
