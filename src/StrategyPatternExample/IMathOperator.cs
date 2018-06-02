using System;

namespace StrategyPatternExample
{
    public interface IMathOperator<out T> where T : Enum
    {
        T Operator { get; }

        int Calculate(int a, int b);
    }
}