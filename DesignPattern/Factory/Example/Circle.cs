using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory
{
    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("画⚪");
        }
    }
}
