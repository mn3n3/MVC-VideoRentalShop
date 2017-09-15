using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoRentalShopWep.Models
{
    public class Rental
    {
        public int Id { get; set; }

        public Movie Movie { get; set; }

        public int MovieID { get; set; }

        public Customer Customer { get; set; }
        public int CustomerID { get; set; }
    }
}