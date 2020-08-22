using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern4.Iterator
{
    public interface IIterator
    {
        public bool HasNext();

        public object Next();
    }
}
