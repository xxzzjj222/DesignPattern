using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPattern6.Observer.Examples
{
    class LStudentClient : AbstractObserver
    {
        public override string Name { get; set; }

        public LStudentClient(string name)
        {
            Name = name;
        }

        public override void Receive(Notice notice)
        {
            Console.WriteLine($"{Name}收到通知：{notice.Message},开始准备考试");
        }
    }
}
