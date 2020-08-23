using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPattern6.EventBus.Examples
{
    class ConnectionListener : IEventListener
    {
        public void OnEvent(Event @event)
        {
            Console.WriteLine("事件被触发了");
        }
    }
}
