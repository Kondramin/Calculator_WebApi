using Calculator_WebApi.Core;
using Calculator_WebApi.Services.Interfaces;
using System;

namespace Calculator_WebApi.Services.Realizations
{
    internal class MathOperation : IMathOperation
    {
        public int DoMathOperation(Calculator calculator)
        {
            switch (calculator.Operand)
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
                    throw new InvalidOperationException($"Operand value \"{calculator.Operand}\" is invalid or not implemented");
            }
        }
    }
}
