using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class Default1Controller : Controller
    {
        // GET: Default1
        public ActionResult Index()
        {
            return View();
        }


        //localhost:56588/default1/first/10
        public ActionResult First(int id=0)
        {
            ViewBag.Id = id;
            return View();
        }
        public ActionResult second(int id = 0)
        {
            ViewBag.Id = id;
            return View();
        }
    }
}