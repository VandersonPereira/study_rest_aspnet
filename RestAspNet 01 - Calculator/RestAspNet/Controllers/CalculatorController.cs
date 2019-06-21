using Microsoft.AspNetCore.Mvc;
using System;

namespace RestAspNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // GET api/calculator/5/5
        [HttpGet("{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if(IsNumeric(firstNumber) && IsNumeric(secondNumber))
                return Ok(SumNumbers(firstNumber, secondNumber));

            return BadRequest("Não foi possivel processar a informação. Error: Invalid input.");
        }

        private string SumNumbers(string firstNumber, string secondNumber)
        {
            return (Convert.ToDecimal(firstNumber) + Convert.ToDecimal(secondNumber)).ToString();
        }

        private bool IsNumeric(string number)
        {
            return decimal.TryParse(number, out decimal realNumber);
        }
    }
}
