using System;
namespace Property
{
    class PropertyClass
    {
        private int privateValue;
        public int PrivateValue
        {
            get { return privateValue; } // get-accessor
            set { privateValue = value; } // set-accessor
        }
        public void PrintValue()
        {
            Console.WriteLine("Hidden Value = " + privateValue);
        }

        class PropertyApp
        {
            public static void Main()
            {
                int n;
                PropertyClass obj = new PropertyClass();
                obj.PrivateValue = 100; // invoke set-accessor
                obj.PrintValue();
                n = obj.PrivateValue; // invoke get-accessor
                Console.WriteLine(" Value = " + n);
            }
        }
    }
}
