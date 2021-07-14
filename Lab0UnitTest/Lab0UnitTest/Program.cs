
using System;

namespace Lab02UnitTest
{
   public class Program
    {
        static public decimal Balance = 0;

        static public void Main(string[] args)
        {
            UserInterface(Balance);
        }
        static void UserInterface(decimal Balance)
        {
            Console.WriteLine("Welcome to Bank of J&M Credit Union. Please Select An Option");
            Console.WriteLine();
            Console.WriteLine("Press 1 to View Balance");
            Console.WriteLine();
            Console.WriteLine("Press 2 to Withdrawl");
            Console.WriteLine();
            Console.WriteLine("Press 3 to Deposit");
            Console.WriteLine();
            Console.WriteLine("Press 4 to Exit");
            Console.WriteLine();

            bool flag = false;
            string userOption = Console.ReadLine();

            while (flag == false)
            {
                if (userOption == "1")
                {
                    flag = true;
                    ViewBalance(Balance);
                }
                else if (userOption == "2")
                {
                    flag = true;
                    Balance = Withdraw(Balance);
                }
                else if (userOption == "3")
                {
                    flag = true;
                    Balance = Deposit(Balance);
                }
                else if (userOption == "4")
                {
                    flag = true;
                    Console.WriteLine("Thank You for Choosing J&M Credit Union!");
                    Environment.Exit(0);
                }
                else
                {

                    Console.WriteLine("Try Again or Push 4 to Exit");
                }

            }
            Console.WriteLine();
            UserInterface(Balance);
            Console.WriteLine();
        }
        static public decimal ViewBalance(decimal balance)
        {
            Console.WriteLine($"Your balance is: ${balance}");

            return balance;
        }
        static public decimal Withdraw(decimal balance)
        {
            Console.WriteLine("Enter your withdraw amount");
            decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
            if (withdrawAmount <= 0 || withdrawAmount > balance)
            {
                Console.WriteLine("Withdraw Amount cannot be $0 or greater than your balance");
                return balance;
            }
            else
            {
                return balance - withdrawAmount;

            }

        }

        static public decimal Deposit(decimal balance)
        {
            Console.WriteLine("Enter your deposit amount");
            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
            if (depositAmount <= 0)
            {
                Console.WriteLine("You can't deposit a negative amount");
                return balance;
            }
            else
            {
                return balance + depositAmount;

            }
        }
    }

}