using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ASP.NET_MVC_5_Demos.Services;

namespace ASP.NET_MVC_5_Demos.Controllers
{
    public class HomeController : Controller
    {
        private ICacheService cacheService;

        public HomeController(ICacheService cacheService)
        {
            this.cacheService = cacheService;
        }

        public IActionResult Index()
        {
            this.ViewBag.Bookmarks = this.cacheService.Bookmars;
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "My new application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
