using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LudwigStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View("StudyView");
        }

        public ActionResult StudyView()
        {
            List<Models.StudyGroup> Student = new List<Models.StudyGroup>();
            Student.Add(new Models.StudyGroup { StudentNumber = 23580152, Name = "Ludwig", Surname = "Nel", Email = "u23580152@tuks.co.za" });
            Student.Add(new Models.StudyGroup { StudentNumber = 22730797, Name = "Lereko", Surname = "Thokoa", Email = "u22730797@tuks.co.za" });
            Student.Add(new Models.StudyGroup { StudentNumber = 01234567, Name = "Jane", Surname = "Doe", Email = "jane.doe@tuks.co.za" });
            Student.Add(new Models.StudyGroup { StudentNumber = 12345678, Name = "John", Surname = "Doe", Email = "john.doe@tuks.co.za" });
            Student.Add(new Models.StudyGroup { StudentNumber = 78367741, Name = "Tom", Surname = "Smith", Email = "tom.smith@tuks.co.za" });

            return View(Student);
        }


    }
}