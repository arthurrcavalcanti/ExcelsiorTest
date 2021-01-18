using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExcelsiorFinanceCalc.API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ExcelsiorFinanceCalc.API.Controllers
{
    [ApiController]
    [Route("/")]
    public class OperationController : ControllerBase
    {
        private readonly IAdd _add;
        private readonly IMult _mult;
        private readonly IDiv _div;
        private readonly ISub _sub;
        private readonly ILogger<OperationController> _logger;

        public OperationController(IAdd add, IMult mult, IDiv div, ISub sub, ILogger<OperationController> logger)
        {
            _add = add;
            _mult = mult;
            _div = div;
            _sub = sub;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Servidor Escutando!");
        }

        [HttpPost]
        [Route("SOMA")]
        public IActionResult Adding([FromBody] NumbersResponse numberResponse)
        {
            try
            {
                numberResponse.Result = _add.Calculate(numberResponse.NumberOne, numberResponse.NumberTwo);
                return Ok(numberResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpPost]
        [Route("MULTIPLICAÇÃO")]
        public IActionResult Multiplying([FromBody] NumbersResponse numberResponse)
        {
            try
            {
                numberResponse.Result = _mult.Calculate(numberResponse.NumberOne, numberResponse.NumberTwo);
                return Ok(numberResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpPost]
        [Route("DIVISÃO")]
        public IActionResult Dividing([FromBody] NumbersResponse numberResponse)
        {
            try
            {
                numberResponse.Result = _div.Calculate(numberResponse.NumberOne, numberResponse.NumberTwo);
                return Ok(numberResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpPost]
        [Route("SUBTRAÇÃO")]
        public IActionResult Subtracting([FromBody] NumbersResponse numberResponse)
        {
            try
            {
                numberResponse.Result = _sub.Calculate(numberResponse.NumberOne, numberResponse.NumberTwo);
                return Ok(numberResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
    }
}
