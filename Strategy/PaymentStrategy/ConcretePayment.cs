using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.PaymentStrategy
{
    public class CrediCardPayment(string nominativo, string cvv, string numerocarta) : IPaymentStrategy
    {
        private readonly string _nominativo = nominativo;
        private readonly string _cvv = cvv;
        private readonly string _numeroCarta = numerocarta;

        public void Paga(float amount)
        {
            Console.WriteLine($"Pagamento effettuato con carta n°{_numeroCarta} {Environment.NewLine} intestata a {_nominativo} {Environment.NewLine} TOTALE: {amount}€");
        }
    }

    public class PayPalPayment(string email) : IPaymentStrategy
    {
        private readonly string _email = email;

        public void Paga(float amount)
        {
            Console.WriteLine($"Pagamento effettuato con account paypal: {_email} {Environment.NewLine} TOTALE: {amount}€");
        }
    }

    public class BitcoinPayment(string wallet) : IPaymentStrategy
    {
        private readonly string _wallet = wallet;

        public void Paga(float amount)
        {
            Console.WriteLine($"Pagamento effettuato con account con wallet: {_wallet} {Environment.NewLine} TOTALE: {amount}€");
        }
    }
}
