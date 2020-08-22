using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace DesignPattern4.Chain.Example
{
    public class DeptManagerLeaveHandler : AbstractHttpHandler
    {
        public DeptManagerLeaveHandler(string handlerName)
        {
            this.HandlerName = handlerName;
        }
        public override void HandlerLeaveRequest(LeaveRequest leaveRequest)
        {
            if (leaveRequest.LeaveDays>MIN && leaveRequest.LeaveDays<=MIDDLE)
            {
                Console.WriteLine("部门经理:" + HandlerName + ",已批准请假;流程结束。");
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
