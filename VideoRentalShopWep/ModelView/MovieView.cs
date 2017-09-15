using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideoRentalShopWep.Models;

namespace VideoRentalShopWep.ModelView
{
    public class MovieView
    {

        public int Id { get; set; }
        public string Name { get; set; }



        public   List<Category> Category { get; set; }

        public int CategoryID { get; set; }

    }
}