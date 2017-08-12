using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookLibrary.Models;
using Microsoft.AspNet.Identity;

namespace BookLibrary.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            using (var db = new ApplicationDbContext())
            {
                var books = db.Books.Include(x=>x.Author).ToList();
                return View(books);
            }
                
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            using (var db = new ApplicationDbContext())
            {
                var book = db.Books.Include(x => x.Author).SingleOrDefault(x=>x.Id == id);

                return View(book);
            }
        }
       

        // GET: Book/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        
        public ActionResult Create(Book book)
        {
            book.AuthorId = User.Identity.GetUserId();
            using (var db = new ApplicationDbContext())
            {
                

                db.Books.Add(book);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
           

        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            using (var db = new ApplicationDbContext())
            {
                var book = db.Books.SingleOrDefault(x => x.Id == id);

                return View(book);
            }
        }

        // POST: Book/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Book book)
        {
            using (var db = new ApplicationDbContext())
            {
                db.Books.Find(id).Title = book.Title;
                db.Books.Find(id).Description = book.Description;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        // GET: Book/Delete/5
        [Authorize]
        public ActionResult Delete(int id)
        {
            using (var db = new ApplicationDbContext())
            {
                var book = db.Books.Include(x => x.Author).SingleOrDefault(x => x.Id == id);

                return View(book);
            }
        }

        // POST: Book/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Book book)
        {
            using (var db = new ApplicationDbContext())
            {
                book = db.Books.SingleOrDefault(x => x.Id == id);
                db.Books.Remove(book);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
        }
    }
}
