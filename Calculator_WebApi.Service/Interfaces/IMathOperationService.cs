using Calculator_WebApi.Core;

namespace Calculator_WebApi.Services.Interfaces
{
    public interface IMathOperationService
    {
        public int DoMathOperation(CalculatorEntity calculator);
    }
}
