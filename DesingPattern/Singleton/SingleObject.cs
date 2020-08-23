using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPattern6.Singleton
{
    class SingleObject
    {
        private static SingleObject instance = new SingleObject();

        private SingleObject()
        { }

        public SingleObject GetInstance()
        {
            return instance;
        }

        public void ShowMessage()
        {
            // 1、产生事件
            Console.WriteLine("Hello 单例!");
        }
    }
}
