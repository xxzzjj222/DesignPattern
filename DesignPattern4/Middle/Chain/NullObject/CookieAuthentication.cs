using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern4.Middle.Chain.NullObject
{
    class CookieAuthentication : IAuthentication
    {
        // 1、缓存用户名(集合) === foreach  迭代器模式
        public void Authentica(HttpContext httpContext)
        {
            Console.WriteLine($"Cookie身份认证");

            // `1、查询身份信息(从数据库) (非常多用户名)
        }
    }
}
