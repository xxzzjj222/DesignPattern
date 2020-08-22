using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern4.Chain.Example
{
    public class DirectLeaderLeaveHandler : AbstractHttpHandler
    {
        public DirectLeaderLeaveHandler(string handlerName)
        {
            this.HandlerName = handlerName;
        }
        public override void HandlerLeaveRequest(LeaveRequest leaveRequest)
        {
            if (leaveRequest.LeaveDays<=this.MIN)
            {
                Console.WriteLine("直接主管:" + HandlerName + ",已批准请假;流程结束。");
                return;
            }

            if (abstractHttpHandler!=null)
            {
                abstractHttpHandler.HandlerLeaveRequest(leaveRequest);
            }
            else
            {
                Console.WriteLine("拒绝请假");
            }
        }
    }
}
