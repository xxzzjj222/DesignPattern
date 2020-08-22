using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.IOC.IOCAttribute
{
    [AttributeUsage(AttributeTargets.Property)]
    public class IOCInject:Attribute
    {
        public IOCInject()
        {

        }
    }
}
