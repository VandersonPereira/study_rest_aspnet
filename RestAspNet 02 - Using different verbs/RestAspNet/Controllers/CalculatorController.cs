using Microsoft.AspNetCore.Mvc;
using System;

namespace RestAspNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // GET api/calculator/sum/5/5
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if(IsNumeric(firstNumber) && IsNumeric(secondNumber))
                return Ok(SumNumbers(firstNumber, secondNumber));

            return BadRequest("Não foi possivel processar a informação. Error: Invalid input.");
        }

        // GET api/calculator/subtraction/5/5
        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult Subtraction(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
                return Ok(SubtractionNumbers(firstNumber, secondNumber));

            return BadRequest("Não foi possivel processar a informação. Error: Invalid input.");
        }

        private string SumNumbers(string firstNumber, string secondNumber) => (Convert.ToDecimal(firstNumber) + Convert.ToDecimal(secondNumber)).ToString();

        private string SubtractionNumbers(string firstNumber, string secondNumber) => (Convert.ToDecimal(firstNumber) - Convert.ToDecimal(secondNumber)).ToString();

        private bool IsNumeric(string number) => decimal.TryParse(number, out decimal realNumber);
    }
}
