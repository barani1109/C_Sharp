using System.Linq;
using System.Web.Http;
using CodeChallenge.Models;

namespace CodeChallenge.Controllers
{
    public class OrdersController : ApiController
    {
        northwindEntities1 db = new northwindEntities1();

        [HttpGet]
        public IHttpActionResult GetOrdersByEmployee()
        {
            var orders = db.Orders
                 .Where(o => o.EmployeeID == 5)
                 .Select(o => new
                 {
                     o.OrderID,
                     o.CustomerID,
                     o.EmployeeID,
                     o.OrderDate,
                     o.RequiredDate,
                     o.ShipCountry
                 })
                 .ToList();

            return Ok(orders);
        }
    }
}