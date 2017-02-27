using ASP.NET_MVC_Essentials_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Essentials_Demo.Controllers
{
    public class PostsController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            var model = new PostInputModel();
            model.Items = new List<SelectListItem>();
            model.Items.Add(new SelectListItem
            {
                Text = "Swimming",
                Value = "1"
            });
            model.Items.Add(new SelectListItem
            {
                Text = "Cycling",
                Value = "2",
                Selected = true
            });
            model.Items.Add(new SelectListItem
            {
                Text = "Running",
                Value = "3"
            });

            return this.View(model);
        }

        [HttpPost]
        public ActionResult Create(PostInputModel model)
        {
            return null;
        }
    }
}