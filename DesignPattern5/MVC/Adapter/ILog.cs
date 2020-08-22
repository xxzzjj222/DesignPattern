using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern5.MVC.Adapter
{
    interface ILog
    {
        public void Debug(string msg);
        public void Info(string msg);
        public void Warn(string msg);
        public void Error(string msg);
    }
}
