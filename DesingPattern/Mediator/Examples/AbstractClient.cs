using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPattern6.Mediator.Examples
{
    abstract class AbstractClient
    {
        protected string name;
        public AbstractClient(string name)
        {
            this.name = name;
        }
        public RoomMediator roomMediator { get; set; }
        public virtual void Receive(string message)
        {
            Console.WriteLine($"{name}接受到消息：{message}");
        }

        public virtual void Send(string message)
        {
            roomMediator.SendMessage(message);
        }
    }
}
