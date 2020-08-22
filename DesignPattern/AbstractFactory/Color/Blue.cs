using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory.Color
{
    class Blue : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Inside Blue::fill() method.");
        }
    }
}
