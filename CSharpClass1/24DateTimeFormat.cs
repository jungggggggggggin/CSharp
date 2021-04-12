using System;
using System.Globalization;
namespace DateTimeFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine(today.ToString("yyyy년 MM월 dd일"));
            Console.WriteLine(string.Format("{0:yyyy년 MM월 dd일}", today));
            Console.WriteLine(today.ToString("MMMM dd, yyyy ddd", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(today.ToString("MMMM dd, yyyy ddd", new CultureInfo("en-US")));
            // 오전, 오후
            Console.WriteLine(today.ToString("tt"));
            today = today.AddHours(12);
            Console.WriteLine(today.ToString("tt"));
            today = today.AddHours(-12);
            Console.WriteLine("\n표준 포맷 지정자");
            // d : 축약된 날짜 형식
            Console.WriteLine("d : " + today.ToString("d"));
            Console.WriteLine("d : " + today.ToString("d", new CultureInfo("en-US")));
        }
    }
}
      