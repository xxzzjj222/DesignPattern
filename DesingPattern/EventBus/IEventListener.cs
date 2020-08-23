using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPattern6.EventBus
{
    /// <summary>
    /// 事件监听器
    /// </summary>
    interface IEventListener
    {
        public void OnEvent(Event @event);
    }
}
