using DesignPattern.AbstractFactory.Color;
using DesignPattern.AbstractFactory.Shape;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract IColor GetColor(string color);

        public abstract IShape GetShape(string shape);
    }
}
