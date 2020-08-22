using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory.Shape
{
    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
}
