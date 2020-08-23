using DesingPattern6.Observer.Examples;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPattern6.Observer
{
    abstract class AbstractObserver
    {
        public abstract string Name { get; set; }

        public abstract void Receive(Notice notice);
    }
}
