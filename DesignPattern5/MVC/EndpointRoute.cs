using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern5.MVC
{
    /// <summary>
    /// Endpoint 路由(根据路径进行匹配Endpoint)
    /// </summary>
    class EndpointRoute
    {
        public EndpointRouteBuilder endpointRouteBuilder { get; set; }

        public Endpoint Match(string requestPath)
        {
            return endpointRouteBuilder.Build().endpoints[requestPath];
        }
    }
}
