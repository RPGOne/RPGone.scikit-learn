using ASP.NET_MVC_5_Demos.Services;
using Microsoft.AspNet.Mvc;

namespace ASP.NET_MVC_5_Demos.ViewComponents
{
    public class SidebarViewComponent : ViewComponent
    {
        private ICacheService cacheService;

        public SidebarViewComponent(ICacheService cacheService)
        {
            this.cacheService = cacheService;
        }

        public IViewComponentResult Invoke(string message)
        {
            var result = string.Format("Hello, this is your message: {0}", message);
            return View(result);
        }
    }

}
