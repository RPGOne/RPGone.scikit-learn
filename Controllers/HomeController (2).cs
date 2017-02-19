namespace AjaxMVCDemos.Controllers
{
    using System;
    using System.Threading;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult ServerTime()
        {
            Thread.Sleep(1000);
            string responseString = String.Format(
                "<div>Time = {0} (IsAjaxRequest = {1})</div>",
                DateTime.Now.ToLongTimeString(), Request.IsAjaxRequest());
            return this.Content(responseString);
        }

        public ActionResult RawAjax()
        {
            return this.View();
        }

        public ActionResult JQueryAjax()
        {
            return this.View();
        }

        public ActionResult UnobtrusiveAjax()
        {
            return this.View();
        }

        public ActionResult AjaxActionLink()
        {
            return this.View();
        }
    }
}
