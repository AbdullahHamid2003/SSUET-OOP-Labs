using System;

namespace ConsoleApp6
{
    class Accout
    {
        public double acc_balance = 50000;
        public void credit(double credit)
        {
            Console.WriteLine("\nYour new balance is :{0}", acc_balance+credit);
        }
        public void debit(double withdraw)
        {
            if (withdraw <= acc_balance)
            {
                Console.WriteLine("Your remaining account balance is: {0}", acc_balance - withdraw);
            }
            else
            {
                Console.WriteLine("Debit amount exceeded account balance.");
                Console.WriteLine("Your account balance is still:{0}", acc_balance);
            }
        }
        public double getbalance()
        {
            return acc_balance;
        }
    }
    class savingAccount : Accout
    {
        public void CalculateInterest(double intrate)
        {
            intrate *= acc_balance;
            Console.WriteLine("your interest earning is:{0}", intrate);
            Console.WriteLine("Your new account balance after earning interest is:{0}",acc_balance+intrate);
        } 
    }
    class CheckingAccount
    {
        public double feecharge;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Accout obj = new Accout();
            Console.Write("Enter the amount you want to credit:");
            double credit = Convert.ToDouble(Console.ReadLine());
            obj.credit(credit); 
            Console.Write("Enter the amount you want to withdraw:");
            double withdraw = Convert.ToDouble(Console.ReadLine());
            obj.debit(withdraw);
            savingAccount obj1 = new savingAccount();
            double intrate = 0.1;
            obj1.CalculateInterest(intrate);
        }
    }
}