namespace StrategyPatternExample
{
    public class MultipleOperator : IMathOperator
    {
        public bool IsApplicable(Operator op)
        {
            return op == Operator.Multiple;
        }

        public int Calculate(int a, int b) => a * b;
    }
}