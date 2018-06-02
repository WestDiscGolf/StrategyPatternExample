using System;
using System.Collections.Generic;
using System.Linq;

namespace StrategyPatternExample
{
    public class MathStrategy : IMathStrategy
    {
        private readonly IEnumerable<IMathOperator<Operator>> _operators;

        public MathStrategy(IEnumerable<IMathOperator<Operator>> operators)
        {
            _operators = operators;
        }

        public int Calculate(int a, int b, Operator op)
        {
            return _operators.FirstOrDefault(x => x.Operator == op)?.Calculate(a, b) ?? throw new ArgumentNullException(nameof(op));
        }
    }
}