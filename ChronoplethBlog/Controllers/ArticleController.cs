using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChronoplethBlog.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index()
        {
            ViewBag.Bla = "bla"; //équivaut à ViewData["bla"] = "bla";
            return View();
        }
    }
}