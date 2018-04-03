namespace StrategyPatternExample
{
    public interface IMathOperator
    {
        Operator Operator { get; }

        int Calculate(int a, int b);
    }
}