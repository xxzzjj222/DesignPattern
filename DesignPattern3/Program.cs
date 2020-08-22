using DesignPattern3.Builder;
using DesignPattern3.Builder.Example;
using DesignPattern3.Configurations;
using DesignPattern3.Configurations.Builders;
using DesignPattern3.Decorator;
using DesignPattern3.Proxy;
using DesignPattern3.Proxy.Example;
using System;

namespace DesignPattern3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1、建造者模式
            {
                //// 1、创建车建造者
                //BikeBuilder bikeBuilder = new BikeBuilder();
                //Bike bike=bikeBuilder.BuildFrame()
                //    .BuildSeat()
                //    .BuildTire()
                //    .Build();
            }
            #endregion

            #region 2、装饰器模式
            {
                //IPayCallback payCallback = new PayCallBack();
                //IPayCallback mailSender = new MailPayCallbackDecorator(payCallback);
                //mailSender.CallbackHandler();
                //IPayCallback smsSender = new SMSPayCallbackDecorator(mailSender);
                ////smsSender.CallbackHandler();
            }

            #endregion

            #region 3、代理模式
            {
                //Image realimage = new ReadImage("test_10mb.jpg");


                //Image image = new ProxyImage("test_10mb.jpg");

                //// 图像将从磁盘加载
                //image.Display();
                //Console.WriteLine("");
                //// 图像不需要从磁盘加载
                //image.Display();


                //// 1、静态代理和装饰器模式非常像，都是做包装
                //// 2、动态代理 

                //// 优点：1、动态扩展原有对象的功能
                //// 缺点：2、说不到，占内存。 

            }
            #endregion

            #region 4、配置Configuration
            {
                // 1、创建ConfigurationBuilder对象
                ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
                configurationBuilder.AddJsonFile("app.json");

                // 2、构建Configuration对象
                Configuration configuration = configurationBuilder.Build();
                string value = configuration["json"];
                Console.WriteLine(value);
            }
            #endregion

            Console.Read();
        }
    }
}
