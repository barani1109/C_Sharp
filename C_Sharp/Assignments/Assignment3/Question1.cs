using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{

    class Accounts
    {
        protected int accountNo;
        protected string customerName;
        protected string accountType;
        protected double balance;

        public Accounts(int accNo, string name, string accType, double bal)
        {
            accountNo = accNo;
            customerName = name;
            accountType = accType;
            balance = bal;
        }

        
        public void ShowData(char tType, double amt)
        {
            Console.WriteLine("\n--- Account Details ---");
            Console.WriteLine("Account No: " + accountNo);
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Account Type: " + accountType);
            Console.WriteLine("Transaction Type: " + tType);
            Console.WriteLine("Amount: " + amt);
            Console.WriteLine("Balance: " + balance);
        }
    }

    class Transaction : Accounts
    {
        private char transactionType;
        private double amount;

        public Transaction(int accNo, string name, string accType, double bal)
            : base(accNo, name, accType, bal)
        {
        }

        public void Credit(double amt)
        {
            balance += amt;
            Console.WriteLine("Deposited: " + amt);
        }

        public void Debit(double amt)
        {
            if (amt <= balance)
            {
                balance -= amt;
                Console.WriteLine("Withdrawn: " + amt);
            }
            else
            {
                Console.WriteLine("Insufficient Balance!");
            }
        }
        public void ProcessTransaction(char tType, double amt)
        {
            transactionType = tType;
            amount = amt;

            if (tType == 'D' || tType == 'd')
                Credit(amt);
            else if (tType == 'W' || tType == 'w')
                Debit(amt);
            else
                Console.WriteLine("Invalid Transaction!");

            ShowData(transactionType, amount);
        }
    }

    internal class Question1
    {
        static void Main(string[] args)
        {
            Transaction t = new Transaction(101, "Arun", "Savings", 5000);

            t.ProcessTransaction('D', 2000);
            t.ProcessTransaction('W', 1500);

            Console.ReadLine();
        }
    }
}
