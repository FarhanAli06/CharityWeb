using ExternalQuoteEngineAPI.Infrastructure.Constants;
using System;
using System.Configuration;
using System.Web;

namespace ExternalQuoteEngineAPI.Infrastructure.Services
{
    public static class ApiLogService
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(ConfigurationManager.AppSettings["QRSLogger"]);

        //public static string BuildExceptionMessage(Exception ex)
        //{
        //    log4net.ThreadContext.Properties[Log4NetCustomFields.UserId] = Convert.ToString(HttpContext.Current.Session["USER_ID"]);
        //    string error = string.Format("{0}Message:{1}", Environment.NewLine, Convert.ToString(ex.Message));
        //    error += string.Format("{0}Inner Exception:{1}", Environment.NewLine, Convert.ToString(ex.InnerException));
        //    error += string.Format("{0}Source:{1}", Environment.NewLine, ex.Source);
        //    error += string.Format("{0}Stack Trace:{1}", Environment.NewLine, ex.StackTrace);
        //    error += string.Format("{0}TargetSite:{1}", Environment.NewLine, ex.TargetSite);
        //    return error;
        //}

        //public static void LogException(Exception ex)
        //{
        //    log.Error(BuildExceptionMessage(ex), ex);
        //}
    }
}
