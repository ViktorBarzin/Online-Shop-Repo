namespace RecommendIT.Web.Application.Controllers
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using Smile_Shop.Application.Infrastructure;
    using Smile_Shop.Data.Services.Contracts;
    using Smile_Shop.ViewModels.User;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Web.Mvc;

    [UserDataFilter]
    public class BaseController : Controller
    {
        public BaseController()
        {
        }

        public BaseController(IUserService u)
        {
            this.users = u;
        }

        public List<string> AllowedImageExtensions = new List<string> { ".jpg", ".png", ".jpeg", ".gif", ".bmp" };
        private IUserService users;
        private UserVm currentUser;
        public UserVm CurrentUser
        {
            get
            {
                if (this.currentUser == null)
                {
                    this.currentUser = this.users.Get(User.Identity.Name);
                }

                return this.currentUser;
            }
        }

        public ActionResult ValidationError(List<string> errors)
        {
            Response.TrySkipIisCustomErrors = true;
            Response.StatusCode = (int)HttpStatusCode.Conflict;
            return this.PartialView(Views.ValidationError, errors.Distinct());
        }

        public ActionResult ValidationError(string error)
        {
            var errors = new List<string> { error };
            Response.TrySkipIisCustomErrors = true;
            Response.StatusCode = (int)HttpStatusCode.Conflict;
            return this.PartialView(Views.ValidationError, errors);
        }

        public ActionResult CustomJson(object content)
        {
            var jsonSerializerSettings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver(), NullValueHandling = NullValueHandling.Ignore };
            var json = JsonConvert.SerializeObject(content, Formatting.Indented, jsonSerializerSettings);

            return this.Content(json, "application/json");
        }
    }
}