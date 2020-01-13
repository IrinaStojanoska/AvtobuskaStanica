using AvtobuskaStanica.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AvtobuskaStanica.Controllers
{
    public class RelationController : Controller
    {

        Relation rel = new Relation();
        // GET: Relation
        Context.ApplicationDbContext db = new Context.ApplicationDbContext();
         public ActionResult OneRelation()
         {

            return View(rel);
         }
        [AllowAnonymous]
        public ActionResult Index()
        {

            return View(db.Relations.ToList());
        }


        // GET: Relation/Details/5
        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
    
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Relation relation = db.Relations.Find(id);
           
            if (relation == null)
            {
                return HttpNotFound();
            }
          
           
           
          
            return View(relation);
        }

        [Authorize(Roles = "Admin,Sales")]
        public ActionResult RelationCustomers(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Relation relation = db.Relations.Find(id);
           // relation.Customers = relation.Customers.ToList();
            if (relation == null)
            {
                return HttpNotFound();
            }

            return View(relation);
        }

        // GET: Relation/Create
        [Authorize(Roles = "Admin,Sales")]
        public ActionResult CreateRelation()
        {
            return View();
        }

        // POST: Relation/Create
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult CreateRelation([Bind(Include = "id,fromDestination,toDestination,priceOneWay, priceRoundTrip,capacity,time,company")] Relation relation)
        {
            if (ModelState.IsValid)
            {
                db.Relations.Add(relation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(relation);
        }

        // GET: Relation/Edit/5
        [Authorize(Roles = "Admin, Sales")]
        
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Relation relation = db.Relations.Find(id);
            if (relation == null)
            {
                return HttpNotFound();
            }
            return View(relation);

        }

        // POST: Relation/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
     
        public ActionResult Edit([Bind(Include = "id,fromDestination,toDestination,priceOneWay, priceRoundTrip,capacity,time,company")] Relation relation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(relation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(relation);
        }

        [AllowAnonymous]
        public ActionResult TicketSale(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Relation relation = db.Relations.Find(id);
            if (relation == null)
            {
                return HttpNotFound();
            }
            return View(relation);
        }


   

        // GET: Relation/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Relation relation = db.Relations.Find(id);
            if (relation == null)
            {
                return HttpNotFound();
            }
            return View(relation);
        }

        // POST: Relation/Delete/5
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            Relation relation = db.Relations.Find(id);
            db.Relations.Remove(relation);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
