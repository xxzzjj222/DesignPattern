using DesingPattern6.Mediator.Examples;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPattern6.Mediator
{
    class RoomMediator
    {
        public IList<AbstractClient> clients = new List<AbstractClient>();

        public void RegisterClient(AbstractClient client)
        {
            clients.Add(client);
        }

        public void SendMessage(string message)
        {
            foreach (var client in clients)
            {
                client.Receive(message);
            }
        }
    }
}
