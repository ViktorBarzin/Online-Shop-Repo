using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Smile_Shop.ViewModels.User;

namespace Smile_Shop.Application.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Profile()
        {
            return this.View();
        }

        public ActionResult Login()
        {
            return null;
        }
    }
}