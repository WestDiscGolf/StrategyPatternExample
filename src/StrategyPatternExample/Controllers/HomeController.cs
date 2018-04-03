using Microsoft.AspNetCore.Mvc;

namespace StrategyPatternExample.Controllers
{
    public class HomeController : ControllerBase
    {
        private readonly IMathStrategy _mathStrategy;

        public HomeController(IMathStrategy mathStrategy)
        {
            _mathStrategy = mathStrategy;
        }

        public IActionResult Index()
        {
            int a = 10;
            int b = 5;
            int result = _mathStrategy.Calculate(a, b, Operator.Add);
            return Content(result.ToString());
        }
    }
}
