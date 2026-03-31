using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class SaleDetails
    {
        private int salesNo;
        private int productNo;
        private double price;
        private int qty;
        private DateTime dateOfSale;
        private double totalAmount;

        public SaleDetails(int sNo, int pNo, double pr, int quantity, DateTime date)
        {
            salesNo = sNo;
            productNo = pNo;
            price = pr;
            qty = quantity;
            dateOfSale = date;
        }
        public void Sales()
        {
            totalAmount = qty * price;
        }

        public static void ShowData(SaleDetails s)
        {
            Console.WriteLine("\n--- Sale Details ---");
            Console.WriteLine("Sales No: " + s.salesNo);
            Console.WriteLine("Product No: " + s.productNo);
            Console.WriteLine("Price: " + s.price);
            Console.WriteLine("Quantity: " + s.qty);
            Console.WriteLine("Date of Sale: " + s.dateOfSale.ToShortDateString());
            Console.WriteLine("Total Amount: " + s.totalAmount);
        }
    }

    internal class Question3
    {
        static void Main(string[] args)
        {
            SaleDetails sale = new SaleDetails(1, 101, 500, 3, DateTime.Now);
            sale.Sales();
            SaleDetails.ShowData(sale);
            Console.ReadLine();
        }
    }
}