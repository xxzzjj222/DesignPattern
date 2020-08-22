using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.IOC.IOCAttribute
{
    [AttributeUsage(AttributeTargets.Class)]
    public class IOCServer: Attribute
    {
        public IOCServer()
        {

        }
    }
}
