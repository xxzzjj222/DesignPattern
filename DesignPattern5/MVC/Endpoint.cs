using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DesignPattern5.MVC
{
    class Endpoint
    {
        /// <summary>
        /// 方法信息
        /// </summary>
        public MethodInfo methodInfo { get; set; }

        /// <summary>
        /// 方法参数
        /// </summary>
        public IList<ParameterInfo> parameterInfos { get; set; }


        /// <summary>
        /// 方法返回值
        /// </summary>
        public object returnValue { get; set; }


        /// <summary>
        /// 控制器
        /// </summary>
        public object Controller { get; set; }

    }
}
