using System;
namespace DivByZeroExceptionApp
{
    class Program1
    {
        public static void Main()
        {
            Console.WriteLine("3개의 정수를 입력하세요 : ");
            int sum = 0, n = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + " >> ");
                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            Console.WriteLine("합은 " + sum);
        }
    }
}
//한칸씩 출력이다 하나 입력하고 엔터!