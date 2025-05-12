namespace Strategy.CalcolatriceStrategy
{
    public class AdditionStrategy : IOperationStrategy
    {
        public float Execute(float a, float b)
        {
            return a + b;
        }
    }

    public class SubtractionStrategy : IOperationStrategy
    {
        public float Execute(float a, float b)
        {
            return a - b;
        }
    }

    public class MultiplicationStrategy : IOperationStrategy
    {
        public float Execute(float a, float b)
        {
            return a * b;
        }
    }

    public class DivisionStrategy : IOperationStrategy
    {
        public float Execute(float a, float b)
        {
            return a / b;
        }
    }
}
