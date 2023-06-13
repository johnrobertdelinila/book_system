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
    public class PurchaseController : Controller
    {
        private BookshopContext db = new BookshopContext();

        // GET: Purchase
        public ActionResult Index(string searchString)
        {
            var purchases = db.Purchases.Include(p => p.Client).Include(p => p.Delivery).Include(p => p.Employee);
            purchases = from p in db.Purchases
                        select p;
            if (!String.IsNullOrEmpty(searchString))
            {
                purchases = purchases.Where(p => p.Ordate.Contains(searchString));
            }
            return View(purchases.ToList());
        }

        // GET: Purchase/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Purchase purchase = db.Purchases.Find(id);
            if (purchase == null)
            {
                return HttpNotFound();
            }
            return View(purchase);
        }

        // GET: Purchase/Create
        public ActionResult Create()
        {
            ViewBag.ClientId = new SelectList(db.Clients, "Id", "Name");
            ViewBag.DeliveryId = new SelectList(db.Deliveries, "Id", "Name");
            ViewBag.EmployeeId = new SelectList(db.Employees, "Id", "Name");
            return View();
        }

        // POST: Purchase/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,EmployeeId,ClientId,DeliveryId,Ordate,Address,Delcost,Saledate")] Purchase purchase)
        {
            if (ModelState.IsValid)
            {
                db.Purchases.Add(purchase);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ClientId = new SelectList(db.Clients, "Id", "Name", purchase.ClientId);
            ViewBag.DeliveryId = new SelectList(db.Deliveries, "Id", "Name", purchase.DeliveryId);
            ViewBag.EmployeeId = new SelectList(db.Employees, "Id", "Name", purchase.EmployeeId);
            return View(purchase);
        }

        // GET: Purchase/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Purchase purchase = db.Purchases.Find(id);
            if (purchase == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClientId = new SelectList(db.Clients, "Id", "Name", purchase.ClientId);
            ViewBag.DeliveryId = new SelectList(db.Deliveries, "Id", "Name", purchase.DeliveryId);
            ViewBag.EmployeeId = new SelectList(db.Employees, "Id", "Name", purchase.EmployeeId);
            return View(purchase);
        }

        // POST: Purchase/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,EmployeeId,ClientId,DeliveryId,Ordate,Address,Delcost,Saledate")] Purchase purchase)
        {
            if (ModelState.IsValid)
            {
                db.Entry(purchase).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ClientId = new SelectList(db.Clients, "Id", "Name", purchase.ClientId);
            ViewBag.DeliveryId = new SelectList(db.Deliveries, "Id", "Name", purchase.DeliveryId);
            ViewBag.EmployeeId = new SelectList(db.Employees, "Id", "Name", purchase.EmployeeId);
            return View(purchase);
        }

        // GET: Purchase/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Purchase purchase = db.Purchases.Find(id);
            if (purchase == null)
            {
                return HttpNotFound();
            }
            return View(purchase);
        }

        // POST: Purchase/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Purchase purchase = db.Purchases.Find(id);
            db.Purchases.Remove(purchase);
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
