using System.Collections.Generic;

namespace ASP.NET_MVC_5_Demos.Services
{
    public interface ICacheService
    {
        IList<string> Bookmars { get; }
    }
}
