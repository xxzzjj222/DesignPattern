using System;

namespace DesignPattern5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1、外观模式
            {
                /*
                // 1、创建微服务
                OrderMicroService orderMicroService = new OrderMicroService();
                PayMicroService payMicroService = new PayMicroService();
                ProductMicroService productMicroService = new ProductMicroService();
                StockMicroService stockMicroService = new StockMicroService();

                // 2、购买商品
                productMicroService.GetProduct();
                orderMicroService.CreateOrder();
                stockMicroService.ReduceStock();
                payMicroService.Pay();


                // 3、使用外观模式
                AggregationMicroServiceFacade aggregationMicroServiceFacade = new AggregationMicroServiceFacade();
                aggregationMicroServiceFacade.BuyProduct();*/


                // 总结：
                // 1、抽象概念：这个对象有哪些角色
                // 2、总结优点：解决了什么问题
                // 3、总结缺点：这个对象会导致什么问题(从这个对象本身出发)
            }
            #endregion

            Console.Read();
        }
    }
}
