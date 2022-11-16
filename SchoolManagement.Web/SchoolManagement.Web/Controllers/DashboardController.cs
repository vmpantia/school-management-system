using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagement.Web.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Student()
        {
            return View("StudentFillUpFormPage");
        }

    }
}