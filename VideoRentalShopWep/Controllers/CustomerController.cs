using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoRentalShopWep.Models;

namespace VideoRentalShopWep.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Customer
        public ActionResult Index()
        {
            List<Customer> Obj = _context.Customers.ToList();
            return View(Obj);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save(Customer Obj)
        {
            _context.Customers.Add(Obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Edit(int id)
        {
            Customer ObjToUpdate = _context.Customers.Where(m => m.Id == id).SingleOrDefault();
            return View(ObjToUpdate);
        }
        [HttpPost]
        public ActionResult Update(Customer Obj)
        {
            Customer ObjToUpdate = _context.Customers.Where(m => m.Id == Obj.Id).SingleOrDefault();
            ObjToUpdate.Name = Obj.Name;
            ObjToUpdate.Phone = Obj.Phone;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Customer ObjToDelete = _context.Customers.Where(m => m.Id == id).SingleOrDefault();
            return View(ObjToDelete);
        }
        [HttpPost]
        public ActionResult Delete(Customer Obj)
        {
            Customer ObjToDelete = _context.Customers.Where(m => m.Id == Obj.Id).SingleOrDefault();
            _context.Customers.Remove(ObjToDelete);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}