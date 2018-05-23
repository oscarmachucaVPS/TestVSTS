using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace AWS.Projtwo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;

            ;
            //Change to test CI Again
            ViewBag.WEbConfigOscar = WebConfigurationManager.AppSettings["WebTransformOscar"];
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