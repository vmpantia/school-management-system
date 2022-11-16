using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagement.Web.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NewStudent()
        {
            return View("StudentFillUpFormPage");
        }

        public ActionResult EditStudent(Guid internalID)
        {
            return View("StudentFillUpFormPage");
        }

    }
}
