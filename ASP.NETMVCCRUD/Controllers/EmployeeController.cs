using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NETMVCCRUD.Models;

namespace ASP.NETMVCCRUD.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult GetData()
        {
            using (DBModels db = new DBModels())
            {
                List<Employee> emplist = db.Employees.ToList<Employee>();
                return Json(new { data = emplist }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult AddOrEdit(int id=0)
        {
            return View(new Employee());
        }
        [HttpPost]
        public ActionResult AddOrEdit()
        {

        }
    }
}