using System;

namespace Assignment_3
{
    class Sale
    {
        protected int salesNo;
        protected int productNo;
        protected double price;
        protected int qty;
        protected DateTime dateOfSale;

        public Sale(int sNo, int pNo, double pr, int quantity, DateTime date)
        {
            salesNo = sNo;
            productNo = pNo;
            price = pr;
            qty = quantity;
            dateOfSale = date;
        }
    }

    class SaleDetails : Sale
    {
        private double totalAmount;

       
        public SaleDetails(int sNo, int pNo, double pr, int quantity, DateTime date)
            : base(sNo, pNo, pr, quantity, date)
        {
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
            SaleDetails s = new SaleDetails(1, 101, 500, 3, DateTime.Now);

            s.Sales();
            SaleDetails.ShowData(s);

            Console.ReadLine();
        }
    }
}