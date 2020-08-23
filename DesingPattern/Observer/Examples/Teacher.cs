using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPattern6.Observer.Examples
{
    class Teacher
    {
        public IList<AbstractObserver> observers = new List<AbstractObserver>();

        public void AddObserver(AbstractObserver observer)
        {
            this.observers.Add(observer);
        }

        public void SendNotice(Notice notice)
        {
            foreach (var observer in observers)
            {
                observer.Receive(notice);
            }
        }
    }
}
