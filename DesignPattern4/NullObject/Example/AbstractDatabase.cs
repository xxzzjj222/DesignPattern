using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern4.NullObject.Example
{
    public abstract class AbstractDatabase
    {
        /// <summary>
        /// 数据库名称
        /// </summary>
        protected string DatabaseName;

        /// <summary>
        /// 数据库url
        /// </summary>
        /// <returns></returns>
        public abstract string GetURL();
    }
}
