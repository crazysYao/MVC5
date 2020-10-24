using MVC5.Models;
using Omu.ValueInjecter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC5.Controllers
{
    public class DepartmentsController : Controller
    {
        ContosoUniversityEntities db = new ContosoUniversityEntities();

        // GET: Departments
        public ActionResult Index()
        {
            
            return View(db.Department.ToList());
        }

        public ActionResult Create()
        {
            ViewBag.InstructorID = new SelectList(db.Person, "ID", "FirstName");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Department department)
        {
            if (ModelState.IsValid)
            {
                db.Department.Add(department);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.InstructorID = new SelectList(db.Person, "ID", "FirstName", department.InstructorID);
            return View(department);
        }

        public ActionResult Edit(int? id)
        {
            var dept = db.Department.Find(id);
            ViewBag.InstructorID = new SelectList(db.Person, "ID", "FirstName", dept.InstructorID);


            return View(db.Department.Find(id));
        }

        [HttpPost]
        public ActionResult Edit(int? id, DepartmentEdit department)
        {
            if (ModelState.IsValid)
            {
                var item = db.Department.Find(id);
                item.InjectFrom(department);// 套件 nuget ValueInjecter
                //item.Budget = department.Budget;
                //item.Name = department.Name;
                //item.StartDate = department.StartDate;
                //item.InstructorID = department.InstructorID; 


                db.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.InstructorID = new SelectList(db.Person, "ID", "FirstName");
            return View(db.Department.Find(id));
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Department department  = db.Department.Find(id);
            if (department == null)
            {
                return HttpNotFound();
            }
            return View(department);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Department department = db.Department.Find(id);
            db.Department.Remove(department);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Department department = db.Department.Find(id);
            if (department == null)
            {
                return HttpNotFound();
            }
            return View(department);
        }

                       

    }
}