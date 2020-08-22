using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.IOC.Strategy
{
    /// <summary>
    /// Activator创建对象策略
    /// </summary>
    public class ActivatorObjectCreateStrategy : IObjectCreateStrategy
    {
        public object CreateObject(Type type)
        {
            return Activator.CreateInstance(type);
        }
    }
}
