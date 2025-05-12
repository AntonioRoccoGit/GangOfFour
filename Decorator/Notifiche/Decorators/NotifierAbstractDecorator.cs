using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Notifiche.Decorators
{
    public abstract class NotifierAbstractDecorator(INotifier wrappee) : INotifier
    {
        protected INotifier _wrappee = wrappee;

        public virtual void SendMessage(string message)
        {
            _wrappee.SendMessage(message);
        }
    }
}
