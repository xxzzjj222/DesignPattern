using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern5.MVC.Adapter.Log4Net
{
    class Log4NetLog : ILog
    {
        private log4net.ILog log;

        public Log4NetLog(log4net.ILog log)
        {
            this.log = log;
        }
        public void Debug(string msg)
        {
            log.Debug(msg);
        }

        public void Error(string msg)
        {
            log.Error(msg);
        }

        public void Info(string msg)
        {
            log.Info(msg);
        }

        public void Warn(string msg)
        {
            log.Warn(msg);
        }
    }
}
