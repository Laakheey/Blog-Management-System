using BlogManagementSystem.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;

namespace BlogManagementSystem.Controllers
{
    [Authorize(Roles = "User,Admin")]
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Admin

        public ActionResult Index(string search, int? i)
        {
            //return View(db.Admins.Where(x => x.Name.StartsWith(search) || search == null).ToList().ToPagedList(page ?? 1, 3));
            return View(db.Blogs.Where(x => x.Author.StartsWith(search) || x.Heading.StartsWith(search) || search == null).ToList().ToPagedList(i ?? 1, 2));

        }

        // GET: Admin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blog blog = db.Blogs.Find(id);
            if (blog == null)
            {
                return HttpNotFound();
            }
            return View(blog);
        }
    }
}