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

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult About(UserVm vm)
        {
            //if (string.is)
            //{
                
            //}

            return null;
        }
    }
}