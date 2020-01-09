using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AvtobuskaStanica.Controllers
{
    public class PageDownController : Controller
    {
        // GET: PageDown
        [AllowAnonymous]
        public ActionResult AboutUs()
        {
            return View();
        }

        // GET: PageDown/Details/5
        [AllowAnonymous]
        public ActionResult Gallery()
        {
            return View();
        }

        // GET: PageDown/Create
        [AllowAnonymous]
        public ActionResult Note()
        {
            return View();
        }

        // POST: PageDown/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PageDown/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PageDown/Edit/5
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

        // GET: PageDown/Delete/5
        [AllowAnonymous]
        public ActionResult ContactPage()
        {
            return View();
        }
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PageDown/Delete/5
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
