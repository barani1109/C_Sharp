using System.Linq;
using System.Web.Mvc;
using Question1.Models;

namespace Question1.Controllers
{
    public class CodeController : Controller
    {
        northwindEntities db = new northwindEntities();

        // Question 1:
        // Display all customers from Germany
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GermanyCustomers()
        {
            var customers = db.Customers
                              .Where(c => c.Country == "Germany")
                              .ToList();

            return View(customers);
        }

        // Question 2:
        // Display customer details for OrderID = 10248
        public ActionResult OrderCustomer()
        {
            var customer = db.Orders
                             .Where(o => o.OrderID == 10248)
                             .Select(o => o.Customer)
                             .FirstOrDefault();

            return View(customer);
        }
    }
}