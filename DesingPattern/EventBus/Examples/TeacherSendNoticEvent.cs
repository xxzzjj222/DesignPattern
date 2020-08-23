using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPattern6.EventBus.Examples
{
    class TeacherSendNoticEvent:Event
    {
        public TeacherSendNoticEvent(object source)
            :base(source)
        {

        }
    }
}
