using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory
{
    class ShapeFactory
    {
        public IShape GetShape(string shapeType)
        {
            if (shapeType==null)
            {
                return null;
            }
            if (shapeType.Equals("CIRCLE"))
            {
                return new Circle();
            }
            else if (shapeType.Equals("RECTANGLE"))
            {
                return new Rectangle();
            }
            else if (shapeType.Equals("SQUARE"))
            {
                return new Square();
            }
            return null;
        }
    }
}
