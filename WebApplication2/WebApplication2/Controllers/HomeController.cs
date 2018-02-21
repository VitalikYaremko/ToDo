using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var UserLogin = User.Identity.Name;
            ViewBag.UserLogin = UserLogin;
            return View();
        }
        [Authorize]//доступ будуть мати тільки авторизовані користувачі
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
         
        public ActionResult About()
        {
            return View();
        }
    }
}