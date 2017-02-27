using System.Collections.Generic;

namespace ASP.NET_MVC_5_Demos.Services
{
    public class CacheService : ICacheService
    {
        public IList<string> Bookmars
        {
            get
            {
                return new List<string>()
                {
                    "IT Bookmark",
                    "Cooking Bookmark",
                    "Traveling Bookmark"
                };
            }
        }
    }
}
