using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern5.Template.Example
{
    public class AliCloudServer : CloudServer
    {
        public override void Connection()
        {
            Console.WriteLine("建立socket连接");
        }

        public override void OpenFile()
        {
            Console.WriteLine("打开日志文件");
        }

        public override void Serialize()
        {
            Console.WriteLine("json序列化日志文件");
        }

        public override void Transport()
        {
            Console.WriteLine("socket传输日志文件");
        }
    }
}
