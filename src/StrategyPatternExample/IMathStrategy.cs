namespace StrategyPatternExample
{
    public interface IMathStrategy
    {
        int Calculate(int a, int b, Operator op);
    }
}