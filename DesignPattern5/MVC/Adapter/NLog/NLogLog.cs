using System;
using System.Collections.Generic;
using System.Text;
using NLog;

namespace DesignPattern5.MVC.Adapter.NLog
{
    class NLogLog : ILog
    {
        private Logger logger;

        public NLogLog(Logger logger)
        {
            // 1、创建日志
            this.logger = logger;
        }

        public void Debug(string msg)
        {
            logger.Debug(msg);
        }

        public void Error(string msg)
        {
            logger.Error(msg);
        }

        public void Info(string msg)
        {
            logger.Info(msg);
        }

        public void Warn(string msg)
        {
            logger.Warn(msg);
        }
    }
}
