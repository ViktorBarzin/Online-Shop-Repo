namespace Smile_Shop.Application.Controllers
{
    using System.Web.Mvc;
    using RecommendIT.Web.Application.Controllers;

    public class HomeController : BaseController
    { 
        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}