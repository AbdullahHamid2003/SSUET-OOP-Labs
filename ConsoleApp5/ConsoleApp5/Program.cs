using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[50];
            Console.Write(" Enter array size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                Console.Write("\n Enter array element [{0}]:", i + 1 );
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        a:
            Console.Write("\n Enter array you want to display:");
            int search = Convert.ToInt32(Console.ReadLine());

            if (search <= size)
            {
                Console.WriteLine("\n The element you entered {0} is correct! ", search);
            }
            else if (search >= size)
            {
                Console.WriteLine("\n Wrong input !!! , please try again ");
            }
            Console.Write("\n Do you want to continue: ");
            char input = Convert.ToChar(Console.ReadLine());
            if (input == 'Y' || input == 'y')
            {
                goto a;
            }
            else if (input == 'N' || input == 'n')
            {
                Console.WriteLine("program ended!! ");
            }
        }
    }
}