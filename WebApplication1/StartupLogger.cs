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
            app.Use<LoggerMiddleware>();

        }
    }
}
