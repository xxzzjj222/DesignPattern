using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory.Shape
{
    class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}
