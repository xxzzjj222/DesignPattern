using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPattern6.EventBus.Examples
{
    class TeacherEventListener : IEventListener
    {
        public void OnEvent(Event @event)
        {
            Console.WriteLine("teacher事件被触发");
        }
    }
}
