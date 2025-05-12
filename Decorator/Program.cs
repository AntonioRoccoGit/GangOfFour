using Decorator.Bevande;
using Decorator.Bevande.Decorator;
using Decorator.Notifiche;
using Decorator.Notifiche.Decorators;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MessageDecorator(false,true);
            MakeBeverage(true, false);
        }

        private static void MessageDecorator(bool useEmail, bool useSms)
        {
            string message = "Confermiamo che l'ordine n°1568945454 è andato a buon fine";

            INotifier notifier = new BaseNotifier();

            if(useSms) 
                notifier = new SMSDecorator(notifier);
            
            if(useEmail) 
                notifier = new EmailDecorator(notifier);

            notifier.SendMessage(message);
        }

        public static void MakeBeverage(bool useSugar, bool useMilk)
        {
            IBeverage drink = new EspressoBeverage();

            if (useSugar)
                drink = new SugarDecorator(drink);

            if (useMilk)
                drink = new MilkDecorator(drink);

            Console.WriteLine($"Hai selezionato: {drink.GetDescription()}");
            Console.WriteLine($"Totale: {drink.GetCost()}");
        }
    }
}
