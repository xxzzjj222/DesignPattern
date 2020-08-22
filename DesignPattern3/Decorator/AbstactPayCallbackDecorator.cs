using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern3.Decorator
{
    public abstract class AbstactPayCallbackDecorator
    {
        protected IPayCallback payCallback;

        public AbstactPayCallbackDecorator(IPayCallback payCallback)
        {
            this.payCallback = payCallback;
        }
    }
}
