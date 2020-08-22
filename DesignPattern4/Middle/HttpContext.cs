using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern4.Middle
{
    public class HttpContext
    {
        public HttpRequest httpRequest { set; get; } // 请求输入类
        public HttpResponse httpResponse { set; get; } // 请求响应输入
    }
}
