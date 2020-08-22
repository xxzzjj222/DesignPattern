using DesignPattern5.MVC.Template;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern5.MVC.Facade
{
    /// <summary>
    /// 终结点中间件(外观模式)
    /// </summary>
    class EndpointMiddlewareFacde
    {
        private EndpointRouteBuilder endpointRouteBuilder;
        private EndpointRoute endpointRoute;
        private EndpointHandler endpointHandler;

        public EndpointMiddlewareFacde()
        {
            this.endpointRouteBuilder = new EndpointRouteBuilder();
            this.endpointRoute = new EndpointRoute();
            this.endpointHandler = new EndpointHandler();
        }

        /// <summary>
        /// 执行请求
        /// </summary>
        /// <param name="httpContext"></param>
        public void Invoke(HttpContext httpContext)
        {
            // 1、加载Controller
            endpointRouteBuilder.MapController();//扫描所有controller

            //路由匹配endpoint
            Endpoint endpoint = endpointRoute.Match("/index");

            //执行endpoint
            object result = endpointHandler.HandlerEndpoint(endpoint,new object[] { "原理解析"});

            //处理结果
            ViewResult viewResult = (ViewResult)result;


            //输出到页面
            if (viewResult.ViewType.Equals("Razor"))
            {
                AbstractView razorView = new RazorView();
                razorView.Render(viewResult.ViewData, httpContext);
            }
            else if (viewResult.ViewType.Equals("Xml"))
            {
                AbstractView xmlView = new XMLView();
                xmlView.Render(viewResult.ViewData, httpContext);
            }
        }
    }
}
