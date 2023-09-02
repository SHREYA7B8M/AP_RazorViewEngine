using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorViewEngine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Request.QueryString["t"] == "")
                ViewData["message"] = "Please select a list type";
            else if (Request.QueryString["t"] == "students")
            {
                ViewData["stype"] = "students";
                ViewData["message"] = "List Of Students";
                List<String> list = new List<string>();
                for (int i = 1; i <= 10; i++)
                {
                    list.Add("Student " + i.ToString());
                }
                ViewData["list"] = list;
            }
            else if (Request.QueryString["t"] == "teachers")
            {
                ViewData["stype"] = "teachers";
                ViewData["message"] = "List Of Teachers";
                List<String> list = new List<string>();
                for (int i = 1; i <= 10; i++)
                {
                    list.Add("Teacher " + i.ToString());
                }
                ViewData["list"] = list;
            }

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
    }
}