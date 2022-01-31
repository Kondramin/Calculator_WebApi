using Calculator_WebApi.Core;
using Calculator_WebApi.Services.Interfaces;
using System;

namespace Calculator_WebApi.Services.Realizations
{
    public class MathOperationService : IMathOperationService
    {
        private readonly CalculatorLogic _CalculatorLogic = new CalculatorLogic();

        public int DoMathOperation(CalculatorEntity calculator)
        {
            switch (calculator.MathOperator)
            {
                case "+":
                    return _CalculatorLogic.Summ(calculator.X, calculator.Y);
                case "-":
                    return _CalculatorLogic.Difference(calculator.X, calculator.Y);
                case "*":
                    return _CalculatorLogic.Multipli(calculator.X, calculator.Y);
                case "/":
                    return _CalculatorLogic.Division(calculator.X, calculator.Y);
                default:
                    throw new InvalidOperationException($"Math operator value \"{calculator.MathOperator}\" is invalid or not implemented");
            }
        }
    }
}
