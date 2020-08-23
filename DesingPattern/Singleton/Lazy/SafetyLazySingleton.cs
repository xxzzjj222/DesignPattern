using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DesingPattern6.Singleton.Lazy
{
    class SafetyLazySingleton
    {
        private volatile static SafetyLazySingleton instance = null;
        private static readonly object padlock = new object();

        private SafetyLazySingleton()
        { }

        public static SafetyLazySingleton Instance
        {
            get
            {
                if (instance==null)
                {
                    lock(padlock)
                    {
                        if (instance==null)
                        {
                            instance = new SafetyLazySingleton();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
