using FactoryMethodPattern.Factories;
using FactoryMethodPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter report type (chart/tabular/summary): ");
            string type = Console.ReadLine().ToLower();

            ReportFactory factory;

            if (type == "chart")
                factory = new ChartFactory();
            else if (type == "tabular")
                factory = new TabularFactory();
            else if (type == "summary")
                factory = new SummaryFactory();
            else
                throw new Exception("Invalid report type");

            IReport report = factory.CreateReport();
            report.GenerateReport();
        }
    }
}
