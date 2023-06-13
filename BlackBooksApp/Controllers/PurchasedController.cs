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
    public class PurchasedController : Controller
    {
        private BookshopContext db = new BookshopContext();

        // GET: Purchased
        public ActionResult Index()
        {
            var purchasedBooks = db.PurchasedBooks.Include(p => p.Book).Include(p => p.Purchase);
            return View(purchasedBooks.ToList());
        }

        // GET: Purchased/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Purchased purchased = db.PurchasedBooks.Find(id);
            if (purchased == null)
            {
                return HttpNotFound();
            }
            return View(purchased);
        }

        // GET: Purchased/Create
        public ActionResult Create()
        {
            ViewBag.BookId = new SelectList(db.Books, "Id", "ISBN");
            ViewBag.PurchaseId = new SelectList(db.Purchases, "Id", "Id");
            return View();
        }

        // POST: Purchased/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,PurchaseId,BookId,OrderPrice,Number")] Purchased purchased)
        {
            if (ModelState.IsValid)
            {
                db.PurchasedBooks.Add(purchased);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BookId = new SelectList(db.Books, "Id", "ISBN", purchased.BookId);
            ViewBag.PurchaseId = new SelectList(db.Purchases, "Id", "Id", purchased.PurchaseId);
            return View(purchased);
        }

        // GET: Purchased/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Purchased purchased = db.PurchasedBooks.Find(id);
            if (purchased == null)
            {
                return HttpNotFound();
            }
            ViewBag.BookId = new SelectList(db.Books, "Id", "ISBN", purchased.BookId);
            ViewBag.PurchaseId = new SelectList(db.Purchases, "Id", "Id", purchased.PurchaseId);
            return View(purchased);
        }

        // POST: Purchased/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PurchaseId,BookId,OrderPrice,Number")] Purchased purchased)
        {
            if (ModelState.IsValid)
            {
                db.Entry(purchased).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BookId = new SelectList(db.Books, "Id", "ISBN", purchased.BookId);
            ViewBag.PurchaseId = new SelectList(db.Purchases, "Id", "Id", purchased.PurchaseId);
            return View(purchased);
        }

        // GET: Purchased/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Purchased purchased = db.PurchasedBooks.Find(id);
            if (purchased == null)
            {
                return HttpNotFound();
            }
            return View(purchased);
        }

        // POST: Purchased/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Purchased purchased = db.PurchasedBooks.Find(id);
            db.PurchasedBooks.Remove(purchased);
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
