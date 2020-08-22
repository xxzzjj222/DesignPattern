using DesignPattern5.Adapter.Example;
using DesignPattern5.MVC;
using DesignPattern5.MVC.Facade;
using DesignPattern5.Template;
using DesignPattern5.Template.Example;
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

            #region 2、适配器模式
            {
                // 1、图片上传服务
                //PictureServer pictureServer = new PictureServer();
                //pictureServer.UploadPicture("mp4", "/123123.jpg");

                //*//*// 视频
                //VideoUploadServer videoUploadServer = new VideoUploadServer();
                //videoUploadServer.UploadVideo("/122212.mp4");


                //// 2、图片适配器(上传视频)
                //PictureServerAdpater pictureServerAdpater = new PictureServerAdpater();
                //pictureServerAdpater.UploadPicture("mp4", "/123123.mp4");

            }
            #endregion

            #region 3、模板方法模式
            {
                //// 1、创建日志文件类
                //LogFile logFile = new LogFile();

                //// 2、保存日志文件到云服务器
                //CloudServer cloudServer = new AzureCloudServer();
                //cloudServer.SaveCloudServer(logFile);
            }
            #endregion

            #region 4、AspNetCore运行原理
            {
                // 完成一个请求
                /*// 1、加载Controller
                EndpointRouteBuilder endpointRouteBuilder = new EndpointRouteBuilder();
                endpointRouteBuilder.MapControllers();// 扫描所有Controller

                // 2、创建EndpointRoute
                EndpointRoute endpointRoute = new EndpointRoute();
                Endpoint endpoint = endpointRoute.Match("/index");

                // 3、执行Endpoint
                EndpointHandler endpointHandler = new EndpointHandler();
                object result = endpointHandler.HandlerEndpoint(endpoint, new object[] { "原理解析" });

                // 4、对结果进行处理*/
                EndpointMiddlewareFacde endpointMiddlewareFacde = new EndpointMiddlewareFacde();
                endpointMiddlewareFacde.Invoke(new HttpContext());

            }
            #endregion

            Console.Read();
        }
    }
}
