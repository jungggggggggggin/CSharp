using System;


namespace Statement
{
    class OverflowApp
    {
        static void Main(string[] args)
        {
            int i, max = int.MaxValue;
            try
            {
                Console.WriteLine("Start of try statement");
                i = max + 1; // default: don't check Overflow.
                Console.WriteLine("After default overflow");
                unchecked
                {
                    i = max + 1; // don't check Overflow intensionally.
                }
                Console.WriteLine("After unchecked statement");
                checked
                {
                    i = max + 1; // check Overflow
                }
                Console.WriteLine("After checked statement");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("caught an OverflowException");
            }

        }
    }
}
