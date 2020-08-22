using DesignPattern5.MVC.Adapter.Log4Net;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern5.MVC.Adapter.NLog
{
    class NLogLogAdapter : ILogAdpater
    {
        public ILog GetLog(Type type)
        {
            return new Log4NetLog(log4net.LogManager.GetLogger("log4net", type));
        }
    }
}
