using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VideoRentalShopWep.Models;

namespace VideoRentalShopWep.Controllers.Api
{
    public class MovieController : ApiController
    {
        private ApplicationDbContext _context;
        public MovieController()
        {
            _context = new ApplicationDbContext();

        }
        //Get /api/customers



        public IHttpActionResult GetMovie(string query = null)
        {
            List<Movie> Movie = new List<Movie>();
            if (!String.IsNullOrWhiteSpace(query))
            {
                Movie = _context.Movies.Where(m => m.Name.Contains(query)).ToList();
            }
            else
            {
                Movie = _context.Movies.ToList();
            }







            return Ok(Movie);
        }
    }
}
