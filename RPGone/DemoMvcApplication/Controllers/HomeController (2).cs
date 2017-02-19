namespace DemoMvcApplication.Controllers
{
    using DemoMvcApplication.Models;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Vlado()
        {
            var obj = new LoginViewModel { Email = "vlado@softuni.bg", Password = "mn0g0slovjaaparol", RememberMe = true };
            return this.View("Pesho", obj);
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