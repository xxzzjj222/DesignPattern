using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace DesingPattern6.Observer.Examples
{
    class ZStudentClient : AbstractObserver
    {
        public override string Name { get; set; }

        public ZStudentClient(string name)
        {
            Name = name;
        }

        public override void Receive(Notice notice)
        {
            Console.WriteLine($"{Name}收到通知：{notice.Message},开始准备考试");
        }
    }
}
