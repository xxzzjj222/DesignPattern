using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern4.Middle.Chain
{
    class IApplication
    {
        // 中间件集合
        public List<Middleware> middlewares { set; get; } = new List<Middleware>();
    }
}
