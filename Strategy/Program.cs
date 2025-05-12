using Strategy.CalcolatriceStrategy;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculatorStrategy();
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


    }
}
