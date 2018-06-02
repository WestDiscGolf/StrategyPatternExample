namespace StrategyPatternExample
{
    public interface IMathOperator
    {
        bool IsApplicable(Operator op);

        int Calculate(int a, int b);
    }
}