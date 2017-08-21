using Blog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class ArticleController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }
        public ActionResult List()
        {
            using (var db = new BlogDbContext())
            {
                var articles = db.Articles.Include(a=>a.Author).ToList();
                return View(articles);
            }
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (var db = new BlogDbContext())
            {
                var article = db.Articles.Where(x => x.Id == id).Include(a => a.Author).First();

                if (article == null)
                {
                    return RedirectToAction("List");
                }

                return View(article);
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Article article)
        {
            if (ModelState.IsValid)
            {
                using (var db = new BlogDbContext())
                {
                    var authorId = db.Users.Where(u => u.UserName == this.User.Identity.Name).First().Id;

                    article.AuthorId = authorId;

                    db.Articles.Add(article);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
            }

            return View(article);
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            using (var db = new BlogDbContext())
            {
                var task = db.Articles.Find(id);

                if (task == null)
                {
                    return RedirectToAction("Index");
                }

                return View(task);
            }
        }


        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            using (var db = new BlogDbContext())
            {
                var article = db.Articles.Where(x=>x.Id == id).Include(a=>a.Author).First();

                if (article == null)
                {
                    return RedirectToAction("Index");
                }

            
                db.Articles.Remove(article);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int id)
        {
            using (var db = new BlogDbContext())
            {
                var article = db.Articles.Where(a=>a.Id == id).First();

                if (article == null)
                {
                    return RedirectToAction("Index");
                }
                

                return View(article);
            }
        }

        [HttpPost]
        [ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int id, Article articleModel)
        {


            using (var db = new BlogDbContext())
            {
                var article = db.Articles.Find(id);

                if (article == null)
                {
                    return RedirectToAction("Index");
                }

                if (string.IsNullOrWhiteSpace(articleModel.Title) || string.IsNullOrWhiteSpace(articleModel.Content))
                {
                    return RedirectToAction("Index");
                }

                article.Title = articleModel.Title;
                article.Content = articleModel.Content;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }
    }
}