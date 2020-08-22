using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern5.Facade.Examples
{
    class StockMicroService
    {
        /// <summary>
        /// 扣减库存
        /// </summary>
        public void ReduceStock()
        {
            Console.WriteLine($"扣减商品库存");
        }
    }
}
