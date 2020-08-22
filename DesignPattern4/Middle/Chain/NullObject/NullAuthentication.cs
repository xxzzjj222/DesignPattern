using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern4.Middle.Chain.NullObject
{
    class NullAuthentication : IAuthentication
    {
        public void Authentica(HttpContext httpContext)
        {
            Console.WriteLine($"身份认证不存在");
        }
    }
}
