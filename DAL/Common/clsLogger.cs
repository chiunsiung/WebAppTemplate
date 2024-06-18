using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL
{
    public class clsLogger
    {
        private static readonly Logger logger = LogManager.GetLogger("Normal");

        public static void ErrorLog(string Message, Exception ex)
        {
            logger.Error(ex, Message + " - ");
        }

        public static void InfoLog(string Message)
        {

            logger.Info(Message);
        }
    }
}