using DesignPattern4.Chain;
using DesignPattern4.Chain.Example;
using DesignPattern4.Iterator;
using DesignPattern4.Iterator.Example;
using DesignPattern4.Middle;
using DesignPattern4.Middle.Chain;
using DesignPattern4.NullObject.Example;
using System;

namespace DesignPattern4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1、责任链模式
            {
                //// 1、创建请假类
                //LeaveRequest request = new LeaveRequest();
                //request.LeaveDays = 2;
                //request.Name = "张三";

                //// 2、链式处理
                //AbstractHttpHandler directLeaderLeaveHandler = new DirectLeaderLeaveHandler("直接领导");
                //AbstractHttpHandler deptManagerLeaveHandler = new DeptManagerLeaveHandler("部门经理");
                //AbstractHttpHandler gManagerLeaveHandler = new GManagerLeaveHandler("总经理");

                //directLeaderLeaveHandler.abstractHttpHandler = deptManagerLeaveHandler;
                //deptManagerLeaveHandler.abstractHttpHandler = gManagerLeaveHandler;

                //// 3、处理请假
                //directLeaderLeaveHandler.HandlerLeaveRequest(request);

            }
            #endregion

            #region 2、迭代器模式
            {
                //List list = new List();
                ////1、for循环遍历
                ////string[] names = list.GetNames();
                ////for (int i = 0; i < names.Length; i++)
                ////{
                ////    Console.WriteLine("Name : " + names[i]);
                ////}

                ////2、迭代器遍历
                //for (IIterator iter = list.GetIterator(); iter.HasNext();)
                //{
                //    string name = (string)iter.Next();
                //    Console.WriteLine("Name : " + name);
                //}

            }
            #endregion


            #region 3、空对象模式
            {
                //AbstractDatabase customer1 = DatabaseFactory.GetDatabase("mysql");
                //AbstractDatabase customer2 = DatabaseFactory.GetDatabase("sqlserver");
                //AbstractDatabase customer3 = DatabaseFactory.GetDatabase("oarcle");
                //AbstractDatabase customer4 = DatabaseFactory.GetDatabase("db2");

                //Console.WriteLine("数据库切换");
                //Console.WriteLine(customer1.GetURL());
                //Console.WriteLine(customer2.GetURL());
                //Console.WriteLine(customer3.GetURL());
                //Console.WriteLine(customer4.GetURL());

            }
            #endregion

            #region 4、Middleware实现原理
            {
                // 1、创建IApplicationBuilder
                IApplicationBuilder applicationBuilder = new IApplicationBuilder();
                applicationBuilder.UseAuthentication();
                applicationBuilder.UseAuthorization();
                applicationBuilder.UseException();

                // 2、构建中间件
                Middleware middleware = applicationBuilder.Build();

                // 3、执行中间件
                HttpContext httpContext = new HttpContext();
                httpContext.httpRequest = new HttpRequest() { requestUrl = "index.html" };
                middleware.HandlerRequest(httpContext);

            }
            #endregion

            Console.Read();
        }
    }
}
