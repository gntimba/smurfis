using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using smurfis.Models;
using smurfis.ModelViews;
using smurfis.util;

namespace smurfis.Controllers
{
    public class HomeController : Controller
    {

        private PreSchoolData db = new PreSchoolData();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(loginView loginview)
        {
            HashPassword hashPassword = new HashPassword();

            var log = (from r in db.employees
                       where r.email == loginview.Email
                       select new loginView
                       {
                           Email = r.email,
                           password = r.ePassword,
                           salt = r.Salt,
                           ID_employee = r.ID_Employee
                       }).ToList();
            if (log != null)
            {
                if (hashPassword.isPasswordValid(loginview.password, log[0].salt, log[0].password))
                {

                    var returndata = new 
                    {
                        email=log[0].Email,
                        ID_employee=log[0].ID_employee,
                        logged=true
                    };
                    return Json(returndata);

                }else
                {
                    var returndata = new
                    {
                        logged = false
                    };
                    return Json(returndata);
                }
            }
            else
            {
                var returndata = new
                {
                    logged = false
                };
                return Json(returndata);

            }
                


        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}