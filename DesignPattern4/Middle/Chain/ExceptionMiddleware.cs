using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern4.Middle.Chain
{
    class ExceptionMiddleware : Middleware
    {
        /// <summary>
        /// 中间件是否终止条件
        /// </summary>
        private string token = "exception";

        public override void HandlerRequest(HttpContext httpContext)
        {
            Console.WriteLine($"执行异常中间件");
            // 1、判断请求url是否包含token，包含则终止
            if (httpContext.httpRequest.requestUrl.Contains(token))
            {
                Console.WriteLine($"异常中间件终止了");
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
