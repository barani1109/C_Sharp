using System;

namespace Assignment5
{
    
    public class InsufficientBalanceException : ApplicationException
    {
        public InsufficientBalanceException(string msg) : base(msg) { }
    }

  
    class Account
    {
        private int accountNo;
        private string customerName;
        private string accountType;
        private double balance;

        
        public Account(int accNo, string name, string type, double initialBalance)
        {
            accountNo = accNo;
            customerName = name;
            accountType = type;
            balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine("Deposited: " + amount);
        }

        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new InsufficientBalanceException("Insufficient Balance!");
            }

            balance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
        }

        public void ShowData()
        {
            Console.WriteLine("\n--- Account Details ---");
            Console.WriteLine("Account No: " + accountNo);
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Account Type: " + accountType);
            Console.WriteLine("Balance: " + balance);
        }
    }

    internal class Question1
    {
       static void Main(string[] args)
        {
            Account acc = new Account(101, "Arun", "Savings", 5000);

            try
            {
                Console.Write("Enter deposit amount: ");
                double dep = Convert.ToDouble(Console.ReadLine());
                acc.Deposit(dep);

                acc.ShowData();

                Console.Write("Enter withdraw amount: ");
                double wd = Convert.ToDouble(Console.ReadLine());
                acc.Withdraw(wd);

                acc.ShowData();
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine("Custom Exception: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Enter numbers only.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Transaction Completed.");
            }

            Console.ReadLine();
        }
    }
}