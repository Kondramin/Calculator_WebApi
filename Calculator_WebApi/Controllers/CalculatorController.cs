using AutoMapper;
using Calculator_WebApi.Core;
using Calculator_WebApi.DTO;
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
        public async Task<ActionResult<int>> Post(CalculatorDTO calculatorDTO)
        {
            if(!ModelState.IsValid) return BadRequest();

            var mapperConfig = new MapperConfiguration(cfg=> cfg.CreateMap<CalculatorDTO, CalculatorEntity>());
            var mapper = new Mapper(mapperConfig);
            var mappedCalculatorEntity = mapper.Map<CalculatorEntity>(calculatorDTO);
            
            
            var result = _MathOperationService.DoMathOperation(mappedCalculatorEntity);

            var a = Ok(result);

            return a;
        }

    }
}
