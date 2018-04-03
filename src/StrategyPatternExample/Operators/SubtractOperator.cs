namespace StrategyPatternExample
{
    public class SubtractOperator : IMathOperator
    {
        public Operator Operator => Operator.Substract;

        public int Calculate(int a, int b) => a - b;
    }
}