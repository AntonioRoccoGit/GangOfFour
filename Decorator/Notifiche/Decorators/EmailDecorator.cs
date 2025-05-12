using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Notifiche.Decorators
{
    public class EmailDecorator(INotifier wrappee) 
        : NotifierAbstractDecorator(wrappee)
    {
        public override void SendMessage(string message)
        {
            base.SendMessage(message);
            SendEmail(message);
        }

        private static void SendEmail(string message)
        {
            Console.WriteLine($"[Email] Inviata mail con messaggio: {message}");
        }
    }

    public class SMSDecorator(INotifier wrappee)
        : NotifierAbstractDecorator(wrappee)
    {
        public override void SendMessage(string message)
        {
            base.SendMessage(message);
            SendEmail(message);
        }

        private static void SendEmail(string message)
        {
            Console.WriteLine($"[SMS] Inviato sms con messaggio: {message}");
        }
    }
}
