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
        public Blogs LoadData()
        {
            DataAccessLayer db = new DataAccessLayer();
            var data = db.LoadData();
            return data;
        }
        public ActionResult List()
        {
            DataAccessLayer db = new DataAccessLayer();
            var data = db.LoadData();
            ViewBag.Data = data;

            return View();
        }
    }
}