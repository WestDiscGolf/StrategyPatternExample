namespace StrategyPatternExample
{
    public class MathStrategyFactory : IMathStrategyFactory
    {
        private readonly AddOperator _addOperator;
        private readonly SubtractOperator _subtractOperator;
        private readonly MultipleOperator _multipleOperator;
        private readonly DivideOperator _divideOperator;

        public MathStrategyFactory(
            AddOperator addOperator,
            SubtractOperator subtractOperator,
            MultipleOperator multipleOperator,
            DivideOperator divideOperator)
        {
            _addOperator = addOperator;
            _subtractOperator = subtractOperator;
            _multipleOperator = multipleOperator;
            _divideOperator = divideOperator;
        }

        public IMathOperator[] Create() => new IMathOperator[] { _addOperator, _subtractOperator, _multipleOperator, _divideOperator };
    }
}