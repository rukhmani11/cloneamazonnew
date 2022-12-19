using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cloneamazonnew.Controllers
{
    public class frontController : Controller
    {
        // GET: front
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult login()
        {
            return View();
        }
    }
}