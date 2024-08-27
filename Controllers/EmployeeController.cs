using CRUD_With_ViewModalI_InMVC.Models;
using CRUD_With_ViewModalI_InMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_With_ViewModalI_InMVC.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }

        public ActionResult Create()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult Create(EmployeeVM svm)
        {
            Employee s = new Employee();
            if (ModelState.IsValid)
            {
                s.EmployeeName = svm.EmployeeName;
                s.Email = svm.Email;
                s.Phone = svm.Phone;
                s.Address = svm.Address;

                db.Employees.Add(s);
                db.SaveChanges();
                return RedirectToAction("Index");


            }

            return PartialView("_EmployeesView", db.Employees.ToList());
        }
        public ActionResult Edit(int id)
        {
            EmployeeVM svm = new EmployeeVM();
            Employee s = db.Employees.Find(id);
            svm.EmployeeName = s.EmployeeName;
            svm.Email = s.Email;
            svm.Phone = s.Phone;
            svm.Address = s.Address;


            if (s == null)
            {
                return HttpNotFound();

            }

            return PartialView(svm);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmployeeVM svm, int id)
        {
            Employee s = new Employee();
            s = db.Employees.Find(id);
            if (ModelState.IsValid)
            {
                s.EmployeeName = svm.EmployeeName;
                s.Email = svm.Email;
                s.Phone = svm.Phone;
                s.Address = svm.Address;
                db.Employees.Add(s);
                db.Entry(s).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");

            }




            return PartialView("_EmployeesView", db.Employees.ToList());


        }

        public ActionResult Delete(int id)
        {
            Employee s = db.Employees.Find(id);
            EmployeeVM svm = new EmployeeVM();

            svm.EmployeeName = s.EmployeeName;
            svm.Email = s.Email;
            svm.Phone = s.Phone;
            svm.Address = s.Address;
            return PartialView(svm);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteEmployee(int id)
        {
            Employee s = db.Employees.Find(id);
            if (s != null)
            {
                db.Employees.Remove(s);
                db.SaveChanges();
            }
            return RedirectToAction("Index");

        }
        public ActionResult Details(int id)
        {

            Employee s = db.Employees.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            return View(s);

        }

    }
}