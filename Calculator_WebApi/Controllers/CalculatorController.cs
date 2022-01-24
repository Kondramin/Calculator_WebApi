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
        private readonly IMathOperation _MathOperation;

        public CalculatorController(IMathOperation mathOperation)
        {
            _MathOperation = mathOperation;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Calculator calculator)
        {
            if(!ModelState.IsValid) return BadRequest();
            var result = _MathOperation.DoMathOperation(calculator);

            return Ok(result);
        }

    }
}
