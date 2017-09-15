using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoRentalShopWep.Models;
using VideoRentalShopWep.ModelView;
using System.Data.Entity;

namespace VideoRentalShopWep.Controllers
{
    public class MovieController : Controller
    {
        ApplicationDbContext _context;

        public MovieController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Create()
        {
           List<Category> ObjCat = new  List<Category>();
            ObjCat = _context.Categorys.ToList();

            MovieView ObjMView = new MovieView()
            {
                Category = ObjCat,
                CategoryID = 0

            };


            return View(ObjMView);
        }

        [HttpPost]
        public ActionResult Save(MovieView Obj)
        {
            Movie ObjToSave = new Movie();
            ObjToSave.Name = Obj.Name;
            ObjToSave.CategoryID = Obj.CategoryID;
            _context.Movies.Add(ObjToSave);
            _context.SaveChanges();

            return RedirectToAction("Index");


        }

        public ActionResult Index()
        {
            List<Movie> Obj = new List<Movie>();
            Obj = _context.Movies.Include(m => m.Category).ToList();

           


            return View(Obj);
        }


        public ActionResult Edit(int id)
        {

            List<Category> ObjCat = new List<Category>();
            ObjCat = _context.Categorys.ToList();

            Movie ObjMovie = _context.Movies.Where(m => m.Id == id).SingleOrDefault();



            MovieView ObjMView = new MovieView()
            {
                Category = ObjCat,
                CategoryID = ObjMovie.CategoryID,
                Name=ObjMovie.Name

            };

            return View(ObjMView);

        }

        [HttpPost]
        public ActionResult Update(MovieView Obj)
        {
            Movie ObjToSave = _context.Movies.Where(m => m.Id == Obj.Id).SingleOrDefault();
            ObjToSave.Name = Obj.Name;
            ObjToSave.CategoryID = Obj.CategoryID;
           
            _context.SaveChanges();

            return RedirectToAction("Index");


        }





    }
}