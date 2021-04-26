using System;
namespace VirtualMethodApp
{
    class BaseClass
    {
        virtual public void MethodA()
        {
            Console.WriteLine("Base MethodA");
        }
        virtual public void MethodB()
        {
            Console.WriteLine("Base MethodB");
        }
        virtual public void MethodC()
        {
            Console.WriteLine("Base MethodC");
        }
    }
    class DerivedClass : BaseClass
    {
        new public void MethodA()
        {
            Console.WriteLine("Derived MethodA");
        }
        override public void MethodB()
        {
            Console.WriteLine("Derived MethodB");
        }
        public void MethodC()
        {
            Console.WriteLine("Derived MethodC");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass s = new DerivedClass(); // short a =  (short)1  ((왼>오)) 왼쪽이 더 크면 상관없고 ((왼<오))오른쪽이 더크면 에러다 그 에러를 없애는것중 하나가 캐스팅이다!
            s.MethodA();
            s.MethodB();
            s.MethodC();
        }
    }
}