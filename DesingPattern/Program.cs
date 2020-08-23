using DesingPattern6.EventBus.Examples;
using DesingPattern6.Mediator;
using DesingPattern6.Mediator.Examples;
using DesingPattern6.Observer;
using DesingPattern6.Observer.Examples;
using DesingPattern6.Singleton.Examples;
using System;

namespace DesingPattern6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1、观察者模式
            {
                //// 1、创建学生客户端
                //AbstractObserver lStudentClient = new LStudentClient("李学生");
                //AbstractObserver zStudentClient = new ZStudentClient("张学生");

                //// 2、创建老师
                //Teacher teacher = new Teacher();
                //teacher.AddObserver(lStudentClient);
                //teacher.AddObserver(zStudentClient);

                //// 3、发送通告
                //teacher.SendNotice(new Notice { Message = "考试" });

            }
            #endregion

            #region 2、中介者模式
            {
                //// 1、创建中房间类
                //RoomMediator roomMediator = new RoomMediator();

                //// 2、创建客户端
                //AbstractClient clientZ = new ZSClient("张三")
                //{
                //    roomMediator = roomMediator
                //};
                //AbstractClient clientL = new LSClient("李四")
                //{
                //    roomMediator = roomMediator
                //};

                //roomMediator.RegisterClient(clientZ);
                //roomMediator.RegisterClient(clientL);

                //// 3、客户端发送消息
                //clientZ.Send("搞金花");
                //clientL.Send("8点不见不散");

            }
            #endregion

            #region 3、单例模式
            //{
            //    for (int i = 0; i < 100; i++)
            //    {
            //        PoolDataSource poolDataSource = PoolDataSource.GetInstance();
            //        poolDataSource.GetConnection();
            //    }
            //}
            #endregion

            #region 4、EventBus实现原理
            {
                // 1、创建事件总线
                EventBus.EventBus eventBus = EventBus.EventBus.Instance;
                TeacherEventListener teacherEventListener = new TeacherEventListener();
                eventBus.AddListener(teacherEventListener);

                Teacher teacher = new Teacher();
                TeacherSendNoticEvent teacherSendNoticEvent = new TeacherSendNoticEvent(teacher);

                // 2、发布事件
                eventBus.PublishEvent(teacherSendNoticEvent);
            }
            #endregion
        }
    }
}
