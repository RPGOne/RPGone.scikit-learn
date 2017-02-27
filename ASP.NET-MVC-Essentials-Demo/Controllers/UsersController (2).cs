namespace ASP.NET_MVC_Essentials_Demo.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using ASP.NET_MVC_Essentials_Demo.Models;
    using System.IO;
    using System;

    public class UsersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Profile(string username)
        {
            var user = this.db.Users.FirstOrDefault(x => x.UserName == username);

            return this.PartialView(user);
            //return this.Content(string.Format("Username: {0}", user.UserName));
        }

        [Authorize]
        public ActionResult GetFile()
        {
            var person = new
            {
                Name = "GOshko",
                Age = 13,
                Grade = 8
            };
            return Json(person, "application/json", JsonRequestBehavior.AllowGet);
        }

        public ActionResult MyProfile()
        {
            return this.Redirect("/User/VGeorgiev");
        }

        [OutputCache(Duration = 60)]
        [Authorize]
        public ActionResult GetParam(string name)
        {
            return Content(string.Format("{0} - {1}", name, DateTime.Now));
        }
    }
}