using System;

namespace ConsoleApp40
{
    class Marks
    {
        protected int rollNumber = 240; protected double marks; protected string Name;
        public void student()
        {
            rollNumber = ++rollNumber;
            Console.Write("\nEnter The Name Of Student: ");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Name: {0} || Roll Number: {1}", Name, rollNumber);
        }
    }
    class Physics : Marks
    {
        public double physics(double num1)
        {
            double marks1 = num1;
            Console.WriteLine("\nPhysics Marks: {0}", marks1);
            return marks1;
        }
    }
    class Chemistry : Marks
    {
        public double chemistry(double num2)
        {
            double marks2 = num2;
            Console.WriteLine("Chemistry Marks: {0}", marks2);
            return marks2;
        }
    }
    class Math : Marks
    {
        public double math(double num3)
        {
            double marks3 = num3;
            Console.WriteLine("Math Marks: {0}", marks3);
            return marks3;
        }
    }
    class Average : Marks
    {
        public double average(double num1, double num2, double num3)
        {
            marks = num1 + num2 + num3;
            Console.WriteLine("Total Marks Of Three Subjects = {0} ", marks);
            marks = (num1 + num2 + num3) / 3;
            Console.WriteLine("Average Marks Of Three Subjects = {0}", marks);
            return marks;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Physics obj1 = new Physics();
            Chemistry obj2 = new Chemistry();
            Math obj3 = new Math();
            Average obj4 = new Average();
            Console.Write("Enter The Students In Class: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                obj1.student();
                Console.Write("\nEnter Physics Marks: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Chemistry Marks: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Math Marks: ");
                double num3 = Convert.ToDouble(Console.ReadLine());
                obj1.physics(num1);
                obj2.chemistry(num2);
                obj3.math(num3);
                obj4.average(num1, num2, num3);
            }
        }
    }
}