namespace StrategyPatternExample
{
    public class SubtractOperator : IMathOperator<Operator>
    {
        public Operator Operator => Operator.Substract;

        public int Calculate(int a, int b) => a - b;
    }
}