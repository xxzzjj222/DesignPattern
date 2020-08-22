using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern4.Middle.Chain
{
    public abstract class Middleware
    {
        public Middleware nextMiddleware { get; set; }

        public abstract void HandlerRequest(HttpContext httpContext);
    }
}
