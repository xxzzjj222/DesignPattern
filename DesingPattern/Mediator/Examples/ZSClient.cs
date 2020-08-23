using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPattern6.Mediator.Examples
{
    class ZSClient : AbstractClient
    {
        public ZSClient(string name)
            :base(name)
        {

        }

        public override void Receive(string message)
        {
            Console.WriteLine($"{name}接受到消息：{message}");
        }

        public override void Send(string message)
        {
            roomMediator.SendMessage(message);
        }
    }
}
