using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SamplaeMVCProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Added this comment to Home Controller for Git Hub Testing
            // Added This comment via Github Website
            
            // This is another Comment via GitHub Website
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
