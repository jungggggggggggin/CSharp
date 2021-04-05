using System;
namespace PropertyWithManyFieldsApp
{
    class PropertyWithManyFields
    {
        private string text = "Dept. of Software";
        private bool isModified = false;
        public string Text
        {
            get { return text; }
            set { text = value; isModified = true; }
        }
        public void PrintStatus()
        {
            Console.WriteLine("text is \"" + text + "\", and " +
            (isModified ? "is" : "not") + " modified.");
        }
    }
    class Program
    {
        public static void Main()
        {
            PropertyWithManyFields obj = new PropertyWithManyFields();
            obj.PrintStatus();
            obj.Text = "Programming Language Lab";
            obj.PrintStatus();
        }
    }
}