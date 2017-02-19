using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_MVC_5_Demos.Controllers
{


    public class TodoItem
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }

    [Route("api/[controller]")]
    public class TodosController : Controller
    {
        static readonly List<TodoItem> _items = new List<TodoItem>()
        {
            new TodoItem { Id = 1, Title = "First Item" },
            new TodoItem { Id = 2, Title = "Second Item" },
            new TodoItem { Id = 3, Title = "Third Item" },
            new TodoItem { Id = 4, Title = "Forth Item" },
        };

        [HttpGet]
        public IEnumerable<TodoItem> GetAll()
        {
            return _items;
        }

        [HttpGet("{id:int}", Name = "GetByIdRoute")]
        public IActionResult GetById2(int id)
        {
            var item = _items.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                return HttpNotFound();
            }

            return new ObjectResult(item);
        }

        [HttpPost]
        public void CreateTodoItem([FromBody] TodoItem item)
        {
            if (!ModelState.IsValid)
            {
                Context.Response.StatusCode = 400;
            }
            else
            {
                item.Id = 1 + _items.Max(x => (int?)x.Id) ?? 0;
                _items.Add(item);

                string url = Url.RouteUrl("GetByIdRoute", new { id = item.Id },
                    Request.Scheme, Request.Host.ToUriComponent());

                Context.Response.StatusCode = 201;
                Context.Response.Headers["Location"] = url;
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteItem(int id)
        {
            var item = _items.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                return HttpNotFound();
            }
            _items.Remove(item);
            return new HttpStatusCodeResult(204); // 201 No Content
        }
    }
}
