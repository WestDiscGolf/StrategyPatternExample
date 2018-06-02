using System;

namespace StrategyPatternExample
{
    public class DivideOperator : IMathOperator
    {
        public bool IsApplicable(Operator op)
        {
            return op == Operator.Divide;
        }

        public int Calculate(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }

            return a / b;
        }
    }
}