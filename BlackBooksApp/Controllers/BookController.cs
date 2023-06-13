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
    public class BookController : Controller
    {
        private BookshopContext db = new BookshopContext();

        // GET: Book
        public ActionResult Index(string sortOrder, string searchString)
        {
            var books = db.Books.Include(b => b.PublishingHouse).Include(b => b.Supplier).Include(b => b.Type);
            ViewBag.PriceSortParm = String.IsNullOrEmpty(sortOrder) ? "price_desc" : "";
            ViewBag.YearSortParm = sortOrder == "Year" ? "year_desc" : "Year";
            ViewBag.RestSortParm = sortOrder == "Rest" ? "rest_desc" : "Rest";
            books = from b in db.Books
                    select b;
            if (!String.IsNullOrEmpty(searchString))
            {
                books = books.Where(b => b.ISBN.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "price_desc":
                    books = books.OrderByDescending(b => b.BookPrice);
                    break;
                case "Year":
                    books = books.OrderBy(b => b.PublishingYear);
                    break;
                case "year_desc":
                    books = books.OrderByDescending(b => b.PublishingYear);
                    break;
                case "Rest":
                    books = books.OrderBy(b => b.Rest);
                    break;
                case "rest_desc":
                    books = books.OrderByDescending(b => b.Rest);
                    break;
                default:
                    books = books.OrderBy(b => b.BookPrice);
                    break;
            }
            return View(books.ToList());
        }

        // GET: Book/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            ViewBag.PublishingHouseId = new SelectList(db.PublishingHouses, "Id", "Name");
            ViewBag.SupplierId = new SelectList(db.Suppliers, "Id", "Name");
            ViewBag.TypeId = new SelectList(db.Types, "Id", "Category");
            return View();
        }

        // POST: Book/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,PublishingHouseId,SupplierId,ISBN,Name,Author,TypeId,Genre,PublishingYear,Pages,CoverType,BookPrice,SupplyDate,Rest")] Book book)
        {
            if (ModelState.IsValid)
            {
                db.Books.Add(book);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PublishingHouseId = new SelectList(db.PublishingHouses, "Id", "Name", book.PublishingHouseId);
            ViewBag.SupplierId = new SelectList(db.Suppliers, "Id", "Name", book.SupplierId);
            ViewBag.TypeId = new SelectList(db.Types, "Id", "Category", book.TypeId);
            return View(book);
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            ViewBag.PublishingHouseId = new SelectList(db.PublishingHouses, "Id", "Name", book.PublishingHouseId);
            ViewBag.SupplierId = new SelectList(db.Suppliers, "Id", "Name", book.SupplierId);
            ViewBag.TypeId = new SelectList(db.Types, "Id", "Category", book.TypeId);
            return View(book);
        }

        // POST: Book/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PublishingHouseId,SupplierId,ISBN,Name,Author,TypeId,Genre,PublishingYear,Pages,CoverType,BookPrice,SupplyDate,Rest")] Book book)
        {
            if (ModelState.IsValid)
            {
                db.Entry(book).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PublishingHouseId = new SelectList(db.PublishingHouses, "Id", "Name", book.PublishingHouseId);
            ViewBag.SupplierId = new SelectList(db.Suppliers, "Id", "Name", book.SupplierId);
            ViewBag.TypeId = new SelectList(db.Types, "Id", "Category", book.TypeId);
            return View(book);
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // POST: Book/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Book book = db.Books.Find(id);
            db.Books.Remove(book);
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
