using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Notifiche
{
    public class BaseNotifier : INotifier
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"[Base] Messaggio: {message}");
        }
    }
}
