using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern5.MVC
{
    /// <summary>
    /// 构建EndpointDataSources(建造者设计模式)
    /// </summary>
    class EndpointRouteBuilder
    {
        private EndpointDataSources endpointDataSources = new EndpointDataSources();

        /// <summary>
        /// 1、加载Controller类和相关特性
        /// </summary>
        public void MapController()
        {
            // 1、解析controller 和action 装换成Endpoint(反射加载)
            Endpoint endpoint = new Endpoint();
            endpoint.methodInfo = typeof(EndpointRouteBuilder).GetMethods()[0];

            // 2、添加到端点集合
            endpointDataSources.endpoints.Add("/index.html", endpoint);
        }

        /// <summary>
        /// 2、加载RazorPage页面Endpoint
        /// </summary>
        public void MapRazorPage()
        {

        }

        public EndpointDataSources Build()
        {
            return endpointDataSources;
        }
    }
}
