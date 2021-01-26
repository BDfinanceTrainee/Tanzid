using mvcCrud.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcCrud.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        db_testEntities dbobj = new db_testEntities();
        public ActionResult Student()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddStudent(tbl_Student model)
        {
            tbl_Student obj = new tbl_Student();
            obj.Name = model.Name;
            obj.Fname = model.Fname;
            obj.Email = model.Name;
            obj.Mobile = model.Mobile;
            obj.Description = model.Description;

            dbobj.tbl_Student.Add(obj);
            dbobj.SaveChanges();

            return View("Student");
        }
    }
}