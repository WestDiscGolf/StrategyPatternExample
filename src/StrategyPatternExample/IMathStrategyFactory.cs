namespace StrategyPatternExample
{
    public interface IMathStrategyFactory
    {
        IMathOperator[] Create();
    }
}