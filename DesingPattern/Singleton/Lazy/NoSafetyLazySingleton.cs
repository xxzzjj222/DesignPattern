using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPattern6.Singleton.Lazy
{
    class NoSafetyLazySingleton
    {
        private static NoSafetyLazySingleton instance = null;

        private NoSafetyLazySingleton()
        { }

        public static NoSafetyLazySingleton Instance
        {
            get
            {
                if (instance==null)
                {
                    instance = new NoSafetyLazySingleton();
                }
                return instance;
            }
        }
    }
}
