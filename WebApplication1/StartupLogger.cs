using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.IO;
[assembly: OwinStartup(typeof(WebApplication1.StartupLogger))]

namespace WebApplication1
{
    public class StartupLogger
    {
        public void Configuration(IAppBuilder app)
        {
            // Дополнительные сведения о настройке приложения см. на странице https://go.microsoft.com/fwlink/?LinkID=316888
            /*app.Run(context =>
            {
                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("Middleware done.");
            });*/

            /*app.Use((context, next) =>
            {
                TextWriter output = context.Get<TextWriter>("host.TraceOutput");
                return next().ContinueWith(result =>
                {
                    output.WriteLine("Scheme {0} : Method {1} : Path {2} : MS {3}",
                    context.Request.Scheme, context.Request.Method, context.Request.Path, getTime());
                });
            });
            */

            app.Use<LoggerMiddleware>();
        }
    }
}
