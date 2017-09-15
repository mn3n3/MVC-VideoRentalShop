using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoRentalShopWep.Models;

namespace VideoRentalShopWep.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        //
        private ApplicationDbContext _context;

        public CategoryController()
        {
            _context = new ApplicationDbContext();
        }


        public ActionResult Index()
        {
            List<Category> Obj = new List<Category>();
            Obj = _context.Categorys.ToList();

           



            return View(Obj);
        }


        public ActionResult Create()
        { 

            return View();
        }

        [HttpPost]
        public ActionResult Save(Category Obj)
        {
            _context.Categorys.Add(Obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Edit(int id)
        {
            Category Obj = _context.Categorys.Where(x => x.Id == id).SingleOrDefault();

            return View(Obj);



        }
        //1 Action

        [HttpPost]
        public ActionResult Update(Category Obj)
        {
            //1 Action
            //1 Action2

            //1 Action
            Category ObjToUpdate = _context.Categorys.Where(m => m.Id == Obj.Id).SingleOrDefault();

            ObjToUpdate.Name = Obj.Name;
            //action   =action2
            _context.SaveChanges();

            return RedirectToAction("Index");

        }


        public ActionResult Delete(int id)
        {
            Category Obj = _context.Categorys.Where(m => m.Id == id).SingleOrDefault();

            return View(Obj);

        }

        [HttpPost]
        public ActionResult Delete(Category Obj)
        {
            Category ObjToDelete = _context.Categorys.Where(m => m.Id == Obj.Id).SingleOrDefault();


            _context.Categorys.Remove(ObjToDelete);
            _context.SaveChanges();

            return RedirectToAction("Index");

        }




    }
}