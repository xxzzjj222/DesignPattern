using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Strategy
{
    public interface IStrategy
    {
        int DoOperation(int num1, int num2);
    }
}
