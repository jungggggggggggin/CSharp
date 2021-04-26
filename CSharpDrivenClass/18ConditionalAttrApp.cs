#define CSHARP
using System;
using System.Diagnostics;
namespace ConditionalAttrApp
{
    class ConditionalAttr
    {
        [Conditional("CSHARP")]
        public static void CsharpMethod()
        {
            Console.WriteLine("In the CSharp Method ...");
        }
        [Conditional("JAVA")]
        public static void JavaMethod()
        {
            Console.WriteLine("In the Java Method ...");
        }
    }
    class Program
    {
        public static void Main()
        {
            ConditionalAttr.CsharpMethod();
            ConditionalAttr.JavaMethod();
        }
    }
}
//ConditionalAttr.CsharpMethod(); 디버깅하기 숫자누르고 f11이나 f5
