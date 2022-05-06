using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BBTS.Models;

namespace BBTS.Controllers
{
    public class setController : Controller
    {
        appDBcontext dBcontext = new appDBcontext();
        // GET: set
        public ActionResult Index()
        {
            List<employee> emp = dBcontext.employees.ToList();
            return View(emp);
        }
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(employee emp)
        {
            dBcontext.employees.Add(emp);
            dBcontext.SaveChanges();
            return RedirectToAction("index");
        }
    }
}