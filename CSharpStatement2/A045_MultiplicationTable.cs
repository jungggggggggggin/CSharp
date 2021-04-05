using System;
namespace Statements
{
    class A045_MultiplicationTable
    {
        static void Main(string[] args)
        {
            Console.Write("구구단의 출력할 단수를 입력하세요 : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
            }

        }
    }
}
