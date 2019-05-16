using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTNhom.Models;
using PagedList;
using PagedList.Mvc;

namespace TTNhom.Controllers
{
    public class UserController : Controller
    {
        PetLandModel db = new PetLandModel();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Blog()
        {
            var blog = from b in db.Blogs select b;
            return View(blog.ToList());
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Shop()
        {
            return View();
        }
        public PartialViewResult BreadcrumbsPartial()
        {
            return PartialView();
        }
        public ActionResult BlogInfoPartial()
        {
            var lstBlog = db.Blogs.Where(a => a.New == 1).ToList();
            return PartialView(lstBlog);
        }
        //public PartialViewResult listBlog(/*int ? pageIndex*/)
        //{
        //    var item = db.Blogs.ToList();
        //    int _pageIndex = pageIndex ?? 1;
        //    return PartialView(item);/*.ToPagedList(_pageIndex, 2))*/
        //}
        public ActionResult BlogDetail()
        {
            return View();
        }
    }
}