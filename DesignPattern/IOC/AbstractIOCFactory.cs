using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.IOC
{
    /// <summary>
    /// IOC抽象工程
    /// </summary>
    public abstract class AbstractIOCFactory
    {
        /// <summary>
        /// IOC创建对象方法
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        public abstract object GetObject(string typeName);
    }
}
