using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern5.MVC
{
    /// <summary>
    /// Endpoint数据源
    /// </summary>
    class EndpointDataSources
    {
        public IDictionary<string, Endpoint> endpoints { get; set; } = new Dictionary<string, Endpoint>();
    }
}
