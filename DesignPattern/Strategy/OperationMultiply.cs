﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Strategy
{
    class OperationMultiply : IStrategy
    {
        public int DoOperation(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
