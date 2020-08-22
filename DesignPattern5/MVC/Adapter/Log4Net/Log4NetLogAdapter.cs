using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern5.MVC.Adapter.NLog;
using NLog;

namespace DesignPattern5.MVC.Adapter.Log4Net
{
    class Log4NetLogAdapter : ILogAdpater
    {
        public ILog GetLog(Type type)
        {
            return new NLogLog(LogManager.GetLogger("nlog", type));
        }
    }
}
