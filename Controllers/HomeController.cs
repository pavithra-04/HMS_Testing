using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace HMS_Testing.Controllers
{
    public class HomeController : Controller
    {
      
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "About";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult Payments()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult details()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult PagenotFount()
        {
            // partial view 
            ViewBag.Title = "PagenotFount";

            return View();
        }

    }
}
