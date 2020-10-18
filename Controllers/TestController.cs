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
        static List<Person> data = new List<Person>
        {
            new Person() {id=1, Name = "Will", Age =18 },
            new Person() {id=2, Name = "Apple", Age =23 },
            new Person() {id=3, Name = "banana", Age =40 },
            new Person() {id=4, Name = "haha", Age =41 },
        };

        // GET: Test
        public ActionResult Index()
        {
            
            return View(data);
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Person person)
        {
            person.id = data.OrderByDescending(u => u.id).Select(d => d.id).FirstOrDefault() + 1;
            if (ModelState.IsValid)
            {

                // todo : Save
                data.Add(person);

                return RedirectToAction("Index");
            }

            return View(person);
        }

        public ActionResult Edit(int id)
        {

            return View(data.FirstOrDefault(p => p.id == id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,Person person)
        {
            if (ModelState.IsValid)
            {
                var one = data.FirstOrDefault(p => p.id == id);
                one.Name = person.Name;
                one.Age = person.Age;

                return RedirectToAction("Index");
            }

            return View(person);
        }

        public ActionResult Details(int id)
        { 
            return View(data.FirstOrDefault(p => p.id == id));
        }


        public ActionResult Delete(int id)
        {
            return View(data.FirstOrDefault(p => p.id == id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection form)
        {
            //data.Remove
            data.Remove(data.FirstOrDefault(p => p.id == id));
            return RedirectToAction("Index");
        }
    }
}