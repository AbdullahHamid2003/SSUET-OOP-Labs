using System;

namespace ConsoleApp
{
    public class Father
    {
        public string FatherName()
        {
            return "Hamid";
        }
    }
    public class ChildFirst : Father
    {
        public string ChildDName()
        {
            return "Abdullah";
        }
    }
    public class ChildSecond : Father
    {
        public string ChildDName()
        {
            return "Hammad";
        }
    }
    class program
    {
        static public void Main()
        {
            ChildFirst first = new ChildFirst();
            Console.WriteLine("My name is " + first.ChildDName() + ". My father name is " + first.FatherName() + ".");
            ChildSecond second = new ChildSecond();
            Console.WriteLine("My name is " + second.ChildDName() + ". My father name is " + second.FatherName() + ".");
        }
    }
}