using System;
namespace ASP.NET_MVC_Essentials_Demo.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}