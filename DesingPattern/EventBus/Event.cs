using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPattern6.EventBus
{
    /// <summary>
    /// 事件
    /// </summary>
    abstract class Event
    {
        //事件源
        public object source { get; }

        protected Event(object source)
        {
            this.source = source;
        }
    }
}
