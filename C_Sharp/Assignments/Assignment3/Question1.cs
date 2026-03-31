using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Accounts
    {
        private int accountNo;
        private string customerName;
        private string accountType;
        private char transactionType;
        private double amount;
        private double balance;

        public Accounts(int accNo, string name, string accType, double initialBalance)
        {
            accountNo = accNo;
            customerName = name;
            accountType = accType;
            balance = initialBalance;
        }

        public void Credit(double amt)
        {
            balance += amt;
            Console.WriteLine("Amount Deposited: " + amt);
        }

        public void Debit(double amt)
        {
            if (amt <= balance)
            {
                balance -= amt;
                Console.WriteLine("Amount Withdrawn: " + amt);
            }
            else
            {
                Console.WriteLine("Insufficient Balance!");
            }
        }

        public void ProcessTransaction(char transType, double amt)
        {
            transactionType = transType;
            amount = amt;

            if (transactionType == 'D' || transactionType == 'd')
            {
                Credit(amount);
            }
            else if (transactionType == 'W' || transactionType == 'w')
            {
                Debit(amount);
            }
            else
            {
                Console.WriteLine("Invalid Transaction Type!");
            }
        }

        public void ShowData()
        {
            Console.WriteLine("\n--- Account Details ---");
            Console.WriteLine("Account No: " + accountNo);
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Account Type: " + accountType);
            Console.WriteLine("Transaction Type: " + transactionType);
            Console.WriteLine("Amount: " + amount);
            Console.WriteLine("Balance: " + balance);
        }
    }

    internal class Question1
    {
        static void Main(string[] args)
        {
            Accounts acc = new Accounts(1001, "Rahul", "Savings", 5000);

            acc.ProcessTransaction('D', 2000);
            acc.ShowData();

            acc.ProcessTransaction('W', 1500);
            acc.ShowData();

            Console.ReadLine();
        }
    }
}
