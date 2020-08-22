using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory.Color
{
    class Green : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Inside Green::fill() method.");
        }
    }
}
