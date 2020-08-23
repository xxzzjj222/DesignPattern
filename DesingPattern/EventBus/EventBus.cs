using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPattern6.EventBus
{
    /// <summary>
    /// 事件总线
    /// 广播事件
    /// </summary>
    class EventBus
    {
        private EventBus()
        {

        }

        private static EventBus _eventBus = null;

        public static EventBus Instance
        {
            get
            {
                return _eventBus ?? (_eventBus = new EventBus());
            }
        }

        //监听器集合
        private static ISet<IEventListener> eventListeners = new HashSet<IEventListener>();

        /// <summary>
        /// 添加监听器
        /// </summary>
        /// <param name="listener"></param>
        public void AddListener(IEventListener eventListener)
        {
            eventListeners.Add(eventListener);
        }

        /// <summary>
        /// 移除监听器
        /// </summary>
        /// <param name="eventListener"></param>
        public void RemoveListener(IEventListener eventListener)
        {
            eventListeners.Remove(eventListener);
        }

        /// <summary>
        /// 发布事件
        /// </summary>
        /// <param name="evnt"></param>
        public void PublishEvent(Event evnt)
        {
            if (evnt==null)
            {
                throw new ArgumentNullException();
            }
            foreach (var listener in eventListeners)
            {
                listener.OnEvent(evnt);
            }
        }
    }
}
