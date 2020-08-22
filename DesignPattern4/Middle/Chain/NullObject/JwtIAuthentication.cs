using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern4.Middle.Chain.NullObject
{
    class JwtIAuthentication : IAuthentication
    {
        public void Authentica(HttpContext httpContext)
        {
            Console.WriteLine($"Jwt身份认证");
        }
    }
}
