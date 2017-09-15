using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VideoRentalShopWep.Models;

namespace VideoRentalShopWep.Controllers.Api
{
    public class CustomerController : ApiController
    {

        private ApplicationDbContext _context;
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        // ma
        public IHttpActionResult GetCustomer(string query=null)
        {
            List<Customer> CustomerObj = new List<Customer>();

            if (!String.IsNullOrWhiteSpace(query))
            {
                CustomerObj = _context.Customers.Where(m => m.Name.Contains(query)).ToList();
            }
            else
            {
                CustomerObj = _context.Customers.ToList();

            }

            return Ok(CustomerObj);

        }




    }
}
