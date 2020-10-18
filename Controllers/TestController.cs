using MVC5.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            var data = new List<Person>
            {
                new Person() {id=1, Name = "Will", Age =18 },
                new Person() {id=2, Name = "Apple", Age =18 },
                new Person() {id=3, Name = "banana", Age =18 },
                new Person() {id=4, Name = "haha", Age =18 },
            };
            return View(data);
        }
    }
}