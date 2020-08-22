using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern5.Template.Example
{
    class AzureCloudServer : CloudServer
    {
        public override void Connection()
        {
            Console.WriteLine("建立grpc连接");
        }

        public override void OpenFile()
        {
            Console.WriteLine("打开日志文件");
        }

        public override void Serialize()
        {
            Console.WriteLine("xml序列化日志文件");
        }

        public override void Transport()
        {
            Console.WriteLine("grpc传输日志文件");
        }
    }
}
