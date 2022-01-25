using Calculator_WebApi.Core;
using Calculator_WebApi.Services.Interfaces;
using System;

namespace Calculator_WebApi.Services.Realizations
{
    internal class MathOperationService : IMathOperationService
    {
        public int DoMathOperation(Calculator calculator)
        {
            switch (calculator.MathOperator)
            {
                case "+":
                    return calculator.Sum();
                case "-":
                    return calculator.Difference();
                case "*":
                    return calculator.Multipli();
                case "/":
                    return calculator.Division();
                default:
                    throw new InvalidOperationException($"Operand value \"{calculator.MathOperator}\" is invalid or not implemented");
            }
        }
    }
}
