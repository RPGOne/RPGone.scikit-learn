namespace ASP.NET_MVC_5_Demos.Middlewares
{
    using System.Threading.Tasks;

    using Microsoft.AspNet.Builder;
    using Microsoft.AspNet.Http;

    public class AppHeaderMiddleware
    {
        private readonly RequestDelegate next;

        public AppHeaderMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            context.Response.Headers.Append("X-Application", "ASP.NET 5 (vNext) SoftUni");
            await this.next.Invoke(context);
        }
    }

}
