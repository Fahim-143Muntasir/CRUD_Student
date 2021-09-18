using CRUD_Student.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_Student.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        db_testEntities dbobj = new db_testEntities();
        public ActionResult Student(Tbl_student obj)
        {       
            return View(obj);     
        }
        [HttpPost]      
        public ActionResult AddStudent(Tbl_student model)
        { 
            Tbl_student obj = new Tbl_student();
            if (ModelState.IsValid)
            {
                obj.ID = model.ID;
                obj.FirstName = model.FirstName;
                obj.LastName = model.LastName;
                obj.Email = model.Email;
                obj.Mobile = model.Mobile;
                obj.Description = model.Description;

                if(model.ID==0)
                {
                dbobj.Tbl_student.Add(obj);
                dbobj.SaveChanges();
                }
                else
                {
                    dbobj.Entry(obj).State =EntityState.Modified;
                    dbobj.SaveChanges();
                }
            }
            ModelState.Clear();
                return View("Student");
            
        }

        public ActionResult StudentList()
        {
            var res = dbobj.Tbl_student.ToList();
            return View(res);
        }
        public ActionResult Delete(int id)
        {
            var res = dbobj.Tbl_student.Where(x => x.ID == id).First();
            dbobj.Tbl_student.Remove(res);
            dbobj.SaveChanges();
            var list = dbobj.Tbl_student.ToList();
            return View("StudentList",list);
        }
    }
}