namespace StrategyPatternExample
{
    public class AddOperator : IMathOperator
    {
        public bool IsApplicable(Operator op)
        {
            return op == Operator.Add;
        }

        public int Calculate(int a, int b) => a + b;
    }
}