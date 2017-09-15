using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoRentalShopWep.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }



        public Category Category { get; set; }

        public int CategoryID { get; set; }



    }
}