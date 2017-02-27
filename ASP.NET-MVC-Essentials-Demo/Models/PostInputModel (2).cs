using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
namespace ASP.NET_MVC_Essentials_Demo.Models
{
    public class PostInputModel
    {
        [Required(ErrorMessage = "Вкарай Title бе пич!")]
        public string Title { get; set; }

        public string Content { get; set; }

        public int Item { get; set; }

        public List<SelectListItem> Items { get; set; }
    }
}