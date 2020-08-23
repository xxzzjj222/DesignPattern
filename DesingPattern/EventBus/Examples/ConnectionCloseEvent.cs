using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPattern6.EventBus.Examples
{
    class ConnectionCloseEvent : Event
    {
        public ConnectionCloseEvent(object source)
            :base(source)
        {

        }
    }
}
