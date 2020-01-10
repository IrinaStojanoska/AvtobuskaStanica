using AvtobuskaStanica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AvtobuskaStanica.Controllers
{
    public class CustomerController : Controller
    {

        Customer customer = new Customer();
        Context.ApplicationDbContext db = new Context.ApplicationDbContext();
        
        // GET: Customer
        public ActionResult Index()
        {
            
            return View(db.Customers.ToList());
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Customer/Create
        public ActionResult CreateCustomer()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCustomer([Bind(Include = "id,serialNumber,cardNumber,name")] Customer customer)
        {
         
            if (ModelState.IsValid)
            {
                
                //customer.capacity = customer.capacity - 1;
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Index","Home");
            }

            return View(customer);
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
