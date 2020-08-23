using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPattern6.Singleton.Eager
{
    class EagerSingleton
    {
        private  static EagerSingleton instance = new EagerSingleton();

        private EagerSingleton()
        { }

        public EagerSingleton GetInstance()
        {
            return instance;
        }
    }
}
