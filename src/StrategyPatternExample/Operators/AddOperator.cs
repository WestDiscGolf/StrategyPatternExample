namespace StrategyPatternExample
{
    public class AddOperator : IMathOperator
    {
        public Operator Operator => Operator.Add;

        public int Calculate(int a, int b) => a + b;
    }
}