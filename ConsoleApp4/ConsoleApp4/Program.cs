using System;

namespace ConsoleApp4
{
    class Employee
    {
        public void getinfo(int salary, int hours)
        {
            Console.WriteLine("\nThe salary of the worker is : {0}$", salary);
            Console.WriteLine("The working hours of the worker is : {0}", hours);
        }
        public void addsal(int salary)
        {
            Console.WriteLine("\nThe salary of the worker is : {0}$", salary);
            if (salary <= 500)
            {
                Console.WriteLine("The salary of the worker after adding 10$ : {0}$", (salary + 10));
            }
        }
        public void addwork(int hours, int salary)
        {
            if (hours > 6)
            {
                Console.WriteLine("\nThe salary of the worker after doing overtime: {0}$", (salary + 5));
            }
            else if (hours <= 6)
            {
                Console.WriteLine("The salary is same as above!");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int salary, hours;
            Employee obj = new Employee();
            Console.Write("Enter the salary of the worker:");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the working hours of the worker:");
            hours = Convert.ToInt32(Console.ReadLine());
            obj.getinfo(salary , hours);
            obj.addsal(salary);
            obj.addwork(hours , salary);
            Console.ReadLine();
        }
    }
}
