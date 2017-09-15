using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VideoRentalShopWep.Models;
using VideoRentalShopWep.ModelView;

namespace VideoRentalShopWep.Controllers.Api
{
    public class RentalMovieController : ApiController
    {

        private ApplicationDbContext _context;
        public RentalMovieController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRental Obj)
        {

            var Customer = _context.Customers.SingleOrDefault(c => c.Id == Obj.CustomerID);

            if (Customer == null)
                return BadRequest("Customer Id Is Not Valid!");

            var movies = _context.Movies.Where(m => Obj.MovieIds.Contains(m.Id)).ToList();




            foreach (var movie in movies)
            {
                Rental ObjToSave = new Rental();
                ObjToSave.MovieID = movie.Id;
                ObjToSave.CustomerID = Customer.Id;
                _context.Rentals.Add(ObjToSave);
            }
            _context.SaveChanges();
            return Ok();

        }




    }
}
