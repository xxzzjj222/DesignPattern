using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern4.Middle.Chain.NullObject
{
    interface IAuthentication
    {
        /// <summary>
        /// 认证身份
        /// </summary>
        /// <param name="httpContext"></param>
        public void Authentica(HttpContext httpContext);
    }
}
