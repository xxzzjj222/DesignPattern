using DesignPattern5.MVC.Adapter.Log4Net;
using DesignPattern5.MVC.Adapter.NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern5.MVC.Adapter
{
    class LogFactory
    {
        public ILog GetLog(string loggerFlag,Type type)
        {
            if ("log4net".Equals(loggerFlag))
            {
                return new NLogLogAdapter().GetLog(type);
            }
            else if ("nlog".Equals(loggerFlag))
            {
                return new Log4NetLogAdapter().GetLog(type);
            }
            return null;
        }
    }
}
