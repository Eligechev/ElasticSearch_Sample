using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Serilog;
using NLog;
/*
namespace WebApplication1
{
    public static class NlogLogger
    {
        private static readonly ILogger _logger;

        static NlogLogger()
        {
            _logger = new LoggerConfiguration()
                .WriteTo.File(HttpContext.Current.Server.MapPath("~/logs/log-.txt"), rollingInterval: RollingInterval.Day)
                .CreateLogger();
        }
        public static void LogError(string text)
        {
            _logger.Warning(text);
        }
    }
}
*/