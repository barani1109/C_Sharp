using System.Linq;
using System.Web.Http;
using CodeChallenge.Models;

namespace CodeChallenge.Controllers
{
    public class CustomerController : ApiController
    {
        northwindEntities1 db = new northwindEntities1();

        [HttpGet]
        public IHttpActionResult GetCustomersByCountry(string country)
        {
            var customers =
                db.GetCustomersByCountry(country).ToList();

            return Ok(customers);
        }
    }
}