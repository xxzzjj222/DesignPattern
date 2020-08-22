using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DesignPattern.IOC.Strategy
{
    /// <summary>
    /// Assembly创建对象策略
    /// </summary>
    public class AssemblyObjectCreateStrategy : IObjectCreateStrategy
    {
        public object CreateObject(Type type)
        {
            return type.Assembly.CreateInstance(type.FullName);
        }
    }
}
