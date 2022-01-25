using Calculator_WebApi.Core;
using Calculator_WebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Calculator_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly IMathOperationService _MathOperationService;

        public CalculatorController(IMathOperationService mathOperationService)
        {
            _MathOperationService = mathOperationService;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Calculator calculator)
        {
            if(!ModelState.IsValid) return BadRequest();
            var result = _MathOperationService.DoMathOperation(calculator);

            var a = Ok(result);

            return a;
        }

    }
}
