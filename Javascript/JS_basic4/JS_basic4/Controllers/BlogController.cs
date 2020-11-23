using JS_basic4.DataAccess;
using JS_basic4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JS_basic4.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult List()
        {
            DataAccessLayer db = new DataAccessLayer();
            var data = db.ListArticle();

            return View(data);
        }

        public ActionResult New()
        {
            DataAccessLayer db = new DataAccessLayer();
            ViewBag.Category = db.GetCategory();
            ViewBag.Positions = db.GetPosition();
            return View();
        }

        [HttpPost]
        public ActionResult New(Article article)
        {
            DataAccessLayer db = new DataAccessLayer();
            if (ModelState.IsValid)
            {
                var articleId = db.InsertArticle(article);
                foreach (var position in article.Position)
                {
                    db.InsertArticlePosition(articleId, position);
                }
                return RedirectToAction("List");
            }
            else
            {
                ModelState.AddModelError("", "Error in saving data");
                ViewBag.Category = db.GetCategory();
                ViewBag.Positions = db.GetPosition();
                return View(article);
            }
        }

        public ActionResult Edit(int id)
        {
            DataAccessLayer db = new DataAccessLayer();
            var data = db.GetArticle(id);
            ViewBag.Category = db.GetCategory();
            ViewBag.Positions = db.GetPosition();
            ViewBag.ArticlePositions = db.GetArticlePosition(id);

            return View(data);
        }

        [HttpPost]
        public ActionResult Edit(Article article)
        {
            DataAccessLayer db = new DataAccessLayer();

            if (ModelState.IsValid)
            {
                db.UpdateArticle(article);
                foreach (var position in article.Position)
                {
                    db.InsertArticlePosition(article.Id, position);
                }
                return RedirectToAction("List");
            }
            else
            {
                ModelState.AddModelError("", "Error in saving data");
                ViewBag.Category = db.GetCategory();
                ViewBag.Positions = db.GetPosition();
                ViewBag.ArticlePositions = db.GetArticlePosition(article.Id);
                return View(article);
            }
        }

        //[HttpPost]
        public ActionResult Delete(int id)
        {
            DataAccessLayer db = new DataAccessLayer();
            db.DeleteArticle(id);

            return RedirectToAction("List");
        }


        public string ProcessUpload(HttpPostedFileBase file)
        {
            //validate

            //xử lý upload
            file.SaveAs(Server.MapPath("~/Content/img/" + file.FileName));
            return "/Content/IMG/" + file.FileName;
        }

        public ActionResult Search(string searchString)
        {
            DataAccessLayer db = new DataAccessLayer();
            List<Articles> data = new List<Articles>();
            if (string.IsNullOrEmpty(searchString))
            {
                data = db.ListArticle();
            }
            else
            {
                data = db.SearchArticle(searchString);
            }

            ViewBag.searchString = searchString;
            return View(data);
        }
    }
}