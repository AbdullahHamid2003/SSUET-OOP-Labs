using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01
{
    class Task2
    {
        static void Main(string[] args)
        {
            int num1, num2, total, product, difference, quotient;
            Console.WriteLine("Enter two numbers: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            total = num1 + num2;
            product = num1 * num2;
            if (num1 > num2)
            {
                difference = num1 - num2;
            }
            else
            {
                difference = num2 - num1;
            }
            quotient = num1 / num2;
            Console.WriteLine("SUM OF TWO INTEGERS: {0}", total);
            Console.WriteLine("PRODUCT OF TWO INTEGERS: {0}", product);
            Console.WriteLine("DIFFERENCE OF TWO INTEGERS: {0}", difference);
            Console.WriteLine("QUOTIENT OF TWO INTEGERS: {0}", quotient);
            Console.ReadLine();
        }
    }
}
