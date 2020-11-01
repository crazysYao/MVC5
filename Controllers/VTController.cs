using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5.Controllers
{
    public class VTController : Controller
    {
        // GET: VT
        public ActionResult Index()
        {
            ViewBag.data = new int[] { 1, 2, 3, 4, 5 };
            return View();
        }
    }
}