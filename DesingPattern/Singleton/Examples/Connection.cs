using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesingPattern6.Singleton.Examples
{
    class Connection
    {
        private int status = 0;

        public Connection()
        {
            Thread.Sleep(1000);
            Console.WriteLine($"创建Connection耗时1s");
        }

        public void Close()
        {
            Thread.Sleep(1000);
            Console.WriteLine($"关闭Connection耗时1s");
        }
    }
}
