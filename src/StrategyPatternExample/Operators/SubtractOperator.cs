namespace StrategyPatternExample
{
    public class SubtractOperator : IMathOperator
    {
        public bool IsApplicable(Operator op)
        {
            return op == Operator.Substract;
        }

        public int Calculate(int a, int b) => a - b;
    }
}