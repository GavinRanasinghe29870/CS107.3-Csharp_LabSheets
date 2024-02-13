using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2q2
{

    class BankAccount
    {
        public string AccountNumber { get; set; }
        public double Balance { get; private set; }


        public BankAccount(string accountNumber, double initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Successfully deposited ${amount}. Updated balance: ${Balance}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid deposit amount. Please deposit a positive amount.");
                Console.ReadLine();
            }
        }
    }

    class Program
    {
        static void Main()
        {

            BankAccount account = new BankAccount("123456789", 1000);


            account.Deposit(500);

            Console.WriteLine($"Current balance: ${account.Balance}");
            Console.ReadLine();
        }
    }

}
