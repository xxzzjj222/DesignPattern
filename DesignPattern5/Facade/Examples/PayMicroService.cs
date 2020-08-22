using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern5.Facade.Examples
{
    class PayMicroService
    {
        /// <summary>
        /// 支付
        /// </summary>
        public void Pay()
        {
            Console.WriteLine($"支付成功");
        }
    }
}
