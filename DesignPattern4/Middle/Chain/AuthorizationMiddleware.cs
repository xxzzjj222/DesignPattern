using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern4.Middle.Chain
{
    class AuthorizationMiddleware : Middleware
    {
        /// <summary>
        /// 中间件是否终止条件
        /// </summary>
        private string token = "author_token";

        public override void HandlerRequest(HttpContext httpContext)
        {
            Console.WriteLine($"执行授权中间件");
            // 1、判断请求url是否包含token，包含则终止
            if (httpContext.httpRequest.requestUrl.Contains(token))
            {
                Console.WriteLine($"授权中间件终止了");
                return;
            }
            else
            {
                // 2、执行下一个中间件
                nextMiddleware.HandlerRequest(httpContext);
            }
        }
    }
}
