using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern4.Middle.Chain
{
    class IApplicationBuilder
    {
        public IApplication application = new IApplication();

        /// <summary>
        /// 1、构建异常中间件
        /// </summary>
        public IApplicationBuilder UseException()
        {
            Middleware middleware = new ExceptionMiddleware();
            application.middlewares.Add(middleware);
            return this;
        }

        /// <summary>
        /// 2、构建身份认证中间件
        /// </summary>
        public IApplicationBuilder UseAuthentication()
        {
            // 1、创建身份认证中间件
            Middleware middleware = new AuthenticationMiddleware();

            // 2、添加到应用程序中
            application.middlewares.Add(middleware);

            return this;
        }

        /// <summary>
        /// 3、构建授权中间件
        /// </summary>
        public IApplicationBuilder UseAuthorization()
        {
            // 1、创建身份认证中间件
            Middleware middleware = new AuthorizationMiddleware();

            // 2、添加到应用程序中
            application.middlewares.Add(middleware);

            return this;
        }

        public Middleware Build()
        {
            //创建默认404中间件
            Middleware middlewareFrist = new Default404Middleware();

            List<Middleware> middlewares = application.middlewares;
            middlewares.Reverse();

            foreach (var middleware in middlewares)
            {
                middlewareFrist.nextMiddleware = middleware;

                middlewareFrist = middleware;
            }

            //return middlewareFrist;

            return middlewares[0];
        }
    }
}
