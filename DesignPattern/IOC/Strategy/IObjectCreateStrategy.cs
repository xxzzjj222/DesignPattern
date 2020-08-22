using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.IOC.Strategy
{
    /// <summary>
    /// 对象创建策略
    /// </summary>
    public interface IObjectCreateStrategy
    {
        //创建对象
        public object CreateObject(Type type);
    }
}
