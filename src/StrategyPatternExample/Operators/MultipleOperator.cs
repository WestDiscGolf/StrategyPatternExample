namespace StrategyPatternExample
{
    public class MultipleOperator : IMathOperator<Operator>
    {
        public Operator Operator => Operator.Multiple;

        public int Calculate(int a, int b) => a * b;
    }
}