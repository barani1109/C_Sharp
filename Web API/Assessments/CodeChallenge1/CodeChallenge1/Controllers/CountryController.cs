using CodeChallenge1.Models;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Web;

using System.Web.Http;

namespace CodeChallenge1.Controllers

{

    public class CountryController : ApiController

    {

        static List<Country> countries = new List<Country>()

        {

            new Country { ID = 1, CountryName = "India", Capital = "New Delhi" },
    new Country { ID = 2, CountryName = "USA", Capital = "Washington D.C." },
    new Country { ID = 3, CountryName = "Japan", Capital = "Tokyo" },
    new Country { ID = 4, CountryName = "Australia", Capital = "Canberra" },
    new Country { ID = 5, CountryName = "Canada", Capital = "Ottawa" },
    new Country { ID = 6, CountryName = "France", Capital = "Paris" },
    new Country { ID = 7, CountryName = "Germany", Capital = "Berlin" },
    new Country { ID = 8, CountryName = "United Kingdom", Capital = "London" }

        };

        [HttpGet]

        public IHttpActionResult Get()

        {

            return Ok(countries);

        }

        [HttpGet]

        public IHttpActionResult Get(int id)

        {

            var country = countries.FirstOrDefault(c => c.ID == id);

            if (country == null)

                return NotFound();

            return Ok(country);

        }

        [HttpPost]

        public IHttpActionResult Post(Country country)

        {

            countries.Add(country);

            return Ok("Country Added Successfully");

        }

        [HttpPut]

        public IHttpActionResult Put(int id, Country country)

        {

            var c = countries.FirstOrDefault(x => x.ID == id);

            if (c == null)

                return NotFound();

            c.CountryName = country.CountryName;

            c.Capital = country.Capital;

            return Ok("Country Updated Successfully");

        }

        [HttpDelete]

        public IHttpActionResult Delete(int id)

        {

            var c = countries.FirstOrDefault(x => x.ID == id);

            if (c == null)

                return NotFound();

            countries.Remove(c);

            return Ok("Country Deleted Successfully");

        }

    }

}
 

