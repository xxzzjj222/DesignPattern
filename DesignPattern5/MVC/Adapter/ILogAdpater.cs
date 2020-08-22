using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern5.MVC.Adapter
{
    interface ILogAdpater
    {
        public ILog GetLog(Type type);
    }
}
