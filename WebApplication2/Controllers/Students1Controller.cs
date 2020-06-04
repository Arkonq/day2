using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Data;

namespace WebApplication2.Controllers
{
    public class Students1Controller : Controller
    {
        private Students _students;

        public Students1Controller()
        {
            this._students = new Students();
        }

        public ActionResult Index()
        {
            ViewBag.Title = "List";
            return View(_students.StudentsList);
        }
    }
}