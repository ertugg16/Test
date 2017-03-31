using MyBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlog.Controllers
{
    public class TagController : Controller
    {
        // GET: Tag
        BlogDBContext db = new BlogDBContext();
        public ActionResult GetTagList()
        {
            var result = db.Tags.ToList();
            return View(result);
        }
    }
}