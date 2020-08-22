﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Strategy
{
    class Context
    {
        private IStrategy strategy;
        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public int ExecuteStrategy(int num1,int num2)
        {
            return strategy.DoOperation(num1, num2);
        }
    }
}
