using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern3.Decorator
{
    public class SMSPayCallbackDecorator : AbstactPayCallbackDecorator, IPayCallback
    {
        public SMSPayCallbackDecorator(IPayCallback payCallback)
            :base(payCallback)
        {

        }
        public void CallbackHandler()
        {
            payCallback.CallbackHandler();
            SendSMS();
        }

        private void SendSMS()
        {
            Console.WriteLine($"支付短信发送成功");
        }
    }
}
