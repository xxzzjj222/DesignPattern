using DesignPattern5.Facade.Examples;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern5.Facade
{
    class AggregationMicroServiceFacade
    {
        private OrderMicroService orderMicroService;
        private PayMicroService payMicroService;
        private ProductMicroService productMicroService;
        private StockMicroService stockMicroService;

        public AggregationMicroServiceFacade()
        {
            this.orderMicroService = new OrderMicroService();
            this.payMicroService = new PayMicroService();
            this.productMicroService = new ProductMicroService();
            this.stockMicroService = new StockMicroService();
        }

        /// <summary>
        /// 购买商品
        /// </summary>
        public void BuyProduct()
        {
            productMicroService.GetProduct();
            orderMicroService.CreateOrder();
            stockMicroService.ReduceStock();
            payMicroService.Pay();
        }
    }
}
