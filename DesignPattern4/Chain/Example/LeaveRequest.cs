using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern4.Chain.Example
{
    public class LeaveRequest
    {
        /// <summary>
        /// 请假天数
        /// </summary>
        public int LeaveDays { set; get; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { set; get; }
    }
}
