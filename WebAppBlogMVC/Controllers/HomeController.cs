using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppBlogMVC.Models;

namespace WebAppBlogMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View(new AdminInfo());
        }
        [HttpPost]
        public ActionResult AdminLogin(AdminInfo sign)
        {
            if (ModelState.IsValid)
            {
                if ((sign.EmailId == "nayak@gmail.com") && (sign.Password == "mama123"))
                {

                    Session["UserId"] = Guid.NewGuid();
                    return RedirectToAction("EmployeeList", "AdminInfoes");
                }
                else
                {
                    ModelState.AddModelError("", "Either User Name or Password Incorrect!!!");
                    return View(sign);

                }
            }
            else
            { return View(sign); }

        }

        [HttpGet]
        public ActionResult EmpLogin()
        {
            return View(new EmpInfo());
        }
        [HttpPost]
        public ActionResult EmpLogin(EmpInfo sign)
        {
            if (ModelState.IsValid)
            {
                if ((sign.EmailId == "itishree@gmail.com") && (sign.PassCode == 12345))
                {

                    Session["UserId"] = Guid.NewGuid();
                    return RedirectToAction("SaveBlog", "EmpInfoes");
                }
                else
                {
                    ModelState.AddModelError("", "Either User Name or Password Incorrect!!!");
                    return View(sign);

                }
            }
            else
            { return View(sign); }

        }

    }
}