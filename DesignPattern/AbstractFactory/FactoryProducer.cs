using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(string choice)
        {
            if (choice.Equals("SHAPE"))
            {
                return new ShapeFactory();
            }
            else if (choice.Equals("COLOR"))
            {
                return new ColorFactory();
            }
            return null;
        }
    }
}