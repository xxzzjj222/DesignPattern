using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern3.Decorator
{
    public class MailPayCallbackDecorator : AbstactPayCallbackDecorator, IPayCallback
    {
        public MailPayCallbackDecorator(IPayCallback payCallback)
            :base(payCallback)
        {

        }
        public void CallbackHandler()
        {
            payCallback.CallbackHandler();
           
            SendMail();
        }

        private void SendMail()
        {
            Console.WriteLine($"发送邮件成功");
        }
    }
}
