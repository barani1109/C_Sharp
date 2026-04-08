using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge2
{
    class Products
    {
        public int ProductId;
        public string ProductName;
        public double Price;

        public Products(int id, string name, double price)
        {
            ProductId = id;
            ProductName = name;
            Price = price;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {ProductId}, Name: {ProductName}, Price: {Price}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Products[] products = new Products[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"\nEnter details for Product {i + 1}:");

                Console.Write("Product ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Product Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                products[i] = new Products(id, name, price);
            }

            Array.Sort(products, (p1, p2) => p1.Price.CompareTo(p2.Price));

            Console.WriteLine("\n--- Products Sorted by Price ---\n");

            foreach (Products p in products)
            {
                p.Display();
            }

            Console.ReadLine();
        }
    }
}