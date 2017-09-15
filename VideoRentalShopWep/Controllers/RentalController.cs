using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoRentalShopWep.Models;
namespace VideoRentalShopWep.Controllers
{
    public class RentalController : Controller
    {
        // GET: Rental
        private ApplicationDbContext _context;

        public RentalController()
        {
            _context = new ApplicationDbContext();

        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }


    }
}