using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TTNhom.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Blog()
        {
            return View();
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
    }
}