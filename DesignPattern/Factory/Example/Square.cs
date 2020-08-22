using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory
{
    class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("画正方形");
        }
    }
}
