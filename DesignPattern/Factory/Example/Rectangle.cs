using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory
{
    class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("画矩形");
        }
    }
}
