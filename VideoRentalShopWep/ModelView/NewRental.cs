using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoRentalShopWep.ModelView
{
    public class NewRental
    {

        public int CustomerID { get; set; }
        public List<int> MovieIds { get; set; }
    }
}