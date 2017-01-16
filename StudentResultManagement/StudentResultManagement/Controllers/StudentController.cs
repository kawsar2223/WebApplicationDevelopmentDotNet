using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentResultManagement.Core.BLL;
using StudentResultManagement.Models;

namespace StudentResultManagement.Controllers
{
    public class StudentController : Controller
    {
        SubjectManager subjectManager=new SubjectManager();
        StudentResultManger studentResultManger=new StudentResultManger();
        
        public ActionResult SaveResult()
        {
            IEnumerable<Subject> subjects = subjectManager.GetAll;
            ViewBag.Subjects = subjects;
            return View();
        }

        //
        // POST: /StudentResult/Create
        [HttpPost]
        public ActionResult SaveResult(StudentResult studentResult)
        {
            try
            {
                ViewBag.Message = studentResultManger.Save(studentResult);
                IEnumerable<Subject> subjects = subjectManager.GetAll;
                ViewBag.Subjects = subjects;
                return View();
                
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult ViewStudentResult()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ViewStudentResult(FormCollection collection)
        {
            string regNo = collection["RegistrationNo"];
            if (regNo == null)
            {
                //ViewBag.Message = "Result Not found";
                return View();
            }
            else
            {
                IEnumerable<ViewStudentResult> studentResults = studentResultManger.GetStudentResults.ToList().FindAll(stReg=>stReg.RegistrationNo==regNo);
                if (studentResults.Count() != 0)
                {
                    ViewBag.StudentResults = studentResults;
                    ViewBag.Total = studentResults.Count();
                    return View(); 
                }
               
                    ViewBag.Message = "Not Found";
                    return View(); 
                
                
            }
           
        }
       
    }
}
