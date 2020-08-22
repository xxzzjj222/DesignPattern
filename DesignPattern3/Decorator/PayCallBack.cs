using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern3.Decorator
{
    public class PayCallBack : IPayCallback
    {
        public void CallbackHandler()
        {
            Console.WriteLine($"数据库写入支付处理信息");
        }
    }
}
