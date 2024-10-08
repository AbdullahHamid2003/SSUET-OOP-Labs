using System;

namespace ConsoleApp1
{
    class vehicle
    {
        string model;
        string color;
        string engine;
        int door;
        public vehicle()
        { 
        }
        public vehicle(string a, string b, string c, int d)
        {       
        }
        public void start()
        {
        }
        public void stop()
        {
        }
        public void run()
        {
        }
        public virtual void calculateSpeed()
        {
            double d, s, t;
            Console.WriteLine("Enter time to taken travel:");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter distance");
            d = Convert.ToDouble(Console.ReadLine());
            s = d / t;
            Console.WriteLine("The speed is" + s);
        }
        public void printinfo()
        {
        }
    }    
    class car : vehicle
    {
        public override void calculateSpeed()
        {
            double d, s, t;
            Console.WriteLine("============CAR SPEED===========");
            Console.WriteLine("Enter time to taken travel from car in seconds");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter completed distance of car in meters");
            d = Convert.ToDouble(Console.ReadLine());
            s = d / t;
            Console.WriteLine("The speed of car is " + s + " m/s");
        }
    }
    class bike : vehicle
    {
        public override void calculateSpeed()
        {
            double d, s, t;
            Console.WriteLine("\n============BIKE SPEED=============\n");
            Console.WriteLine("Enter time to taken travel from bike in seconds");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter completed distance of bike in meters");
            d = Convert.ToDouble(Console.ReadLine());
            s = d / t;
            Console.WriteLine("The speed of bike is " + s + " m/s");
        }
    }
    class Program  
    {
        static void Main(string[] args)
        {
            vehicle obj1 = new car();
            vehicle obj2 = new bike();
            obj1.calculateSpeed();
            obj2.calculateSpeed();
            Console.ReadLine();
        }
    }
}