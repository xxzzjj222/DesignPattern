using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern4.Chain.Example
{
    public class GManagerLeaveHandler : AbstractHttpHandler
    {
        public GManagerLeaveHandler(string handlerName)
        {
            this.HandlerName = handlerName;
        }
        public override void HandlerLeaveRequest(LeaveRequest leaveRequest)
        {
            // 1、自己判断先处理
            if (leaveRequest.LeaveDays>MIDDLE && leaveRequest.LeaveDays<=MAX)
            {
                Console.WriteLine("总经理:" + HandlerName + ",已经处理;流程结束。");
                return;
            }
            // 2、给上级领导处理
            if (null != abstractHttpHandler)
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
