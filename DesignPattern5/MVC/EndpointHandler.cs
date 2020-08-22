using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DesignPattern5.MVC
{
    class EndpointHandler
    {
        /// <summary>
        /// 执行端点
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="providerArgs"></param>
        /// <returns></returns>
        public object HandlerEndpoint(Endpoint endpoint,object[] providerArgs)
        {
            MethodInfo methodInfo = endpoint.methodInfo;
            return methodInfo.Invoke(endpoint.Controller, providerArgs);
        }
    }
}
