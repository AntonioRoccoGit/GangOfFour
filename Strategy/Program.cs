using Strategy.CalcolatriceStrategy;
using Strategy.PaymentStrategy;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CalculatorStrategy();
            PaymentStrategy();
        }

        private static void CalculatorStrategy()
        {
            float num1 = 6;
            float num2 = 13;

            Console.WriteLine("Impostata somma");
            var calcolatrice = new CalculatorContext(new AdditionStrategy());
            Console.WriteLine(calcolatrice.Calculate(num1, num2));

            Console.WriteLine("Impostata sottrazione");
            calcolatrice.SetStrategy(new SubtractionStrategy());
            Console.WriteLine(calcolatrice.Calculate(num1, num2));


            Console.WriteLine("Impostata divisione");
            calcolatrice.SetStrategy(new DivisionStrategy());
            Console.WriteLine(calcolatrice.Calculate(num1, num2));

            Console.WriteLine("Impostata moltiplicazione");
            calcolatrice.SetStrategy(new MultiplicationStrategy());
            Console.WriteLine(calcolatrice.Calculate(num1, num2));
        }

        private static void PaymentStrategy()
        {

            var pagamentoConCarta = new CrediCardPayment("Mario Rossi", "123", "4569789456561234");
            var context = new PaymentContext(pagamentoConCarta);
            context.Execute(126.50f);

            var pagamentoPaypal = new PayPalPayment("m.rossi@gmail.com");
            context.SetStrategy(pagamentoPaypal);
            context.Execute(86.50f);

            var pagamentoBitcoin = new BitcoinPayment("0x5832197316548711798");
            context.SetStrategy(pagamentoBitcoin);
            context.Execute(15.78f);
        }

    }
}
