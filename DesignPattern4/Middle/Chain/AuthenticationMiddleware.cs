using DesignPattern4.Chain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern4.Middle.Chain
{
    class AuthenticationMiddleware : Middleware
    {
        /// <summary>
        /// 中间件是否终止条件
        /// </summary>
        private string token = "authen_token";

        public override void HandlerRequest(HttpContext httpContext)
        {
            Console.WriteLine($"执行身份认证中间件");
            if (httpContext.httpRequest.requestUrl.Contains(token))
            {
                Console.WriteLine($"身份认证中间件终止了");
                return;
            }
            else
            {
                nextMiddleware.HandlerRequest(httpContext);
            }
        }
    }
}
