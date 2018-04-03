namespace StrategyPatternExample
{
    public class MultipleOperator : IMathOperator
    {
        public Operator Operator => Operator.Multiple;

        public int Calculate(int a, int b) => a * b;
    }
}