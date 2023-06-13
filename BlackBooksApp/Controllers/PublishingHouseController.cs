using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BlackBooksApp.DAL;
using BlackBooksApp.Models;

namespace BlackBooksApp.Controllers
{
    public class PublishingHouseController : Controller
    {
        private BookshopContext db = new BookshopContext();

        // GET: PublishingHouse
        public ActionResult Index(string sortOrder, string searchString)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            var pubhouses = from p in db.PublishingHouses
                            select p;
            if (!String.IsNullOrEmpty(searchString))
            {
                pubhouses = pubhouses.Where(p => p.Name.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    pubhouses = pubhouses.OrderByDescending(p => p.Name);
                    break;
                default:
                    pubhouses = pubhouses.OrderBy(p => p.Name);
                    break;
            }
            return View(pubhouses.ToList());
        }

        // GET: PublishingHouse/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PublishingHouse publishingHouse = db.PublishingHouses.Find(id);
            if (publishingHouse == null)
            {
                return HttpNotFound();
            }
            return View(publishingHouse);
        }

        // GET: PublishingHouse/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PublishingHouse/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Address,Phone")] PublishingHouse publishingHouse)
        {
            if (ModelState.IsValid)
            {
                db.PublishingHouses.Add(publishingHouse);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(publishingHouse);
        }

        // GET: PublishingHouse/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PublishingHouse publishingHouse = db.PublishingHouses.Find(id);
            if (publishingHouse == null)
            {
                return HttpNotFound();
            }
            return View(publishingHouse);
        }

        // POST: PublishingHouse/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Address,Phone")] PublishingHouse publishingHouse)
        {
            if (ModelState.IsValid)
            {
                db.Entry(publishingHouse).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(publishingHouse);
        }

        // GET: PublishingHouse/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PublishingHouse publishingHouse = db.PublishingHouses.Find(id);
            if (publishingHouse == null)
            {
                return HttpNotFound();
            }
            return View(publishingHouse);
        }

        // POST: PublishingHouse/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PublishingHouse publishingHouse = db.PublishingHouses.Find(id);
            db.PublishingHouses.Remove(publishingHouse);
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
