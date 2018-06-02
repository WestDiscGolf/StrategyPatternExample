using System;
using System.Collections.Generic;
using System.Linq;

namespace StrategyPatternExample
{
    public class MathStrategy : IMathStrategy
    {
        private readonly IEnumerable<IMathOperator> _operators;

        public MathStrategy(IEnumerable<IMathOperator> operators)
        {
            _operators = operators;
        }

        public int Calculate(int a, int b, Operator op)
        {
            foreach (var @operator in _operators)
            {
                if (@operator.IsApplicable(op))
                {
                    return @operator.Calculate(a, b);
                }
            }

            throw new ArgumentNullException(nameof(op));
        }
    }
}