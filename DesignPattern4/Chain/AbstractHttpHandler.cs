using DesignPattern4.Chain.Example;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern4.Chain
{
    public abstract class AbstractHttpHandler
    {
        /**直接主管审批处理的请假天数*/
        protected int MIN = 1;
        /**部门经理处理的请假天数*/
        protected int MIDDLE = 3;
        /**总经理处理的请假天数*/
        protected int MAX = 30;

        protected string HandlerName;

        //责任链中下一个元素
        public AbstractHttpHandler abstractHttpHandler { get; set; }

        public abstract void HandlerLeaveRequest(LeaveRequest leaveRequest);
    }
}
