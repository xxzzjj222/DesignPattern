using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory.Shape
{
    class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}
