using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin;
using NLog;
using Serilog;
using Elasticsearch.Net;

namespace WebApplication1
{
    public static class LogRequestResponseHelper
    {
        public static void LogDebugResponse(Logger logger, IOwinResponse response)
        {
            if (!logger.IsDebugEnabled)
                return;

            MappedDiagnosticsContext.Clear();
            MappedDiagnosticsContext.Set("response.StatusCode", response.StatusCode.ToString());

            logger.Debug(String.Format("Response statuscode:'{0}'.", response.StatusCode));

            MappedDiagnosticsContext.Clear();
        }

        public static void LogTraceResponse(Logger logger, string body)
        {
            if (!logger.IsTraceEnabled)
                return;

            logger.Trace("Response body: {0}", body);
        }

        public static void LogDebugRequest(Logger logger, IOwinRequest request)
        {
            if (!logger.IsDebugEnabled)
                return;
            //Nlog parameters
            MappedDiagnosticsContext.Clear();
            MappedDiagnosticsContext.Set("request.MediaType", request.MediaType);
            MappedDiagnosticsContext.Set("request.Host", request.Host.ToString());
            MappedDiagnosticsContext.Set("request.ContentType", request.ContentType);
            MappedDiagnosticsContext.Set("request.Scheme", request.Scheme);
            MappedDiagnosticsContext.Set("request.Method", request.Method);
            MappedDiagnosticsContext.Set("request.Path", request.Path.ToString());
            MappedDiagnosticsContext.Set("request.IP", request.RemoteIpAddress.ToString());
            MappedDiagnosticsContext.Set("request.Accept", request.Accept);

               logger.Debug("TEXT MESSAGE Request scheme: {Scheme}; method: {Method}; path: {Path}; query: {$RemoteIP} ; accept: {Accept}, dateTime: {DateTime}",
                request.Scheme,
                request.Method,
                request.Path,
                request.RemoteIpAddress,
                request.Accept,
                DateTime.Now);
            MappedDiagnosticsContext.Clear();
            

            //Serilog params
            
            Log.Information("Request scheme: {Scheme}; method: {Method}; path: {Path}; query: {$RemoteIP} ; accept: {Accept}, dateTime: {DateTime}",
                request.Scheme,
                request.Method,
                request.Path,
                request.RemoteIpAddress,
                request.Accept,
                DateTime.Now);
            
            /*
            LogUnit log = new LogUnit();
            log.prop1 = 1;
            log.prop2 = 2;
            Log.Information("object logging sample. pror1 {$prop1}; prop2 {$prop2}", log.prop1, log.prop2);
            */
            Log.CloseAndFlush();
        }
    }
    public class LogUnit
    {
        public int prop1 { get; set; }
        public int prop2 { get; set; }
    }
}