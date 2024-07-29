using API_Pesos.Helpers;
using API_Pesos.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Pesos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeightController : ControllerBase
    {
        [HttpPost("Convert")]
        public IActionResult ConvertWeight (WeightParameters parameters)
        {
            try
            {
                // metodos del helper
                double convertedWeight = WeightConversionHelper.ConvertWeight(parameters.Peso, parameters.FromUnit, parameters.ToUnit);
                parameters.OutputMessage =$"{parameters.Peso}{parameters.FromUnit} es igual a {convertedWeight:0.##}{parameters.ToUnit}";
                return Ok(parameters);
            }

            catch (InvalidOperationException ex)
            {
                //devolver un bad request si algo sale mal
                return BadRequest(ex.Message);
            }
            
        }
    }
}
