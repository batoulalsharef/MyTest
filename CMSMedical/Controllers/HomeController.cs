using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMSMedical.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        

        public ActionResult Consulting()
        {
           
            return View("Consulting");
        }

        public ActionResult Blog()
        {
            
            return View("Blog");
        }
        public ActionResult Login()
        {
            
            return View("login");
        }
        public ActionResult Manag()
        {
            
            return View("manag");
        }
        public ActionResult ProvideAdvice()
        {
            
            return View("ProvideAdvice");
        }
        public ActionResult SendResponse()
        {
            
            return View("SendResponse");
        }
        public ActionResult SingleBlog()
        {
            
            return View("SingleBlog");
        }
    }
}