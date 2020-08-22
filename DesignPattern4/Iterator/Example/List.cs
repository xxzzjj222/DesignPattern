using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern4.Iterator.Example
{
    public class List :IIterable
    {
        public static string[] names = { "张三", "李四", "王五", "赵六", "钱七" };

        public string[] GetNames()
        {
            return names;
        }

        public void Add()
        {

        }

        public IIterator GetIterator()
        {
            return new ListIterator();
        }

        public class ListIterator : IIterator
        {
            int index;
            public bool HasNext()
            {
                if (index<names.Length)
                {
                    return true;
                }
                return false;
            }

            public object Next()
            {
                if (this.HasNext())
                {
                    return names[index++];
                }
                return null;
            }
        }
    }
}
