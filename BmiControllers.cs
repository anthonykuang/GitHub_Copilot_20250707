using Microsoft.AspNetCore.Mvc;
using HOL_GitHub_Copilot_HTML.Services;

namespace HOL_GitHub_Copilot_HTML.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BmiController : ControllerBase
    {
        public class BmiInput
        {
            public double Height { get; set; } // 單位: 公分
            public double Weight { get; set; } // 單位: 公斤
        }

        [HttpGet]
        public IActionResult Get(double height, double weight)
        {
            if (height <= 0 || weight <= 0)
            {
                return BadRequest("請輸入有效的身高和體重。");
            }
            var (bmi, category) = BmiService.CalculateBmi(height, weight);
            return Ok(new { bmi, category });
        }

        [HttpPost]
        public IActionResult Post([FromBody] BmiInput input)
        {
            if (input.Height <= 0 || input.Weight <= 0)
            {
                return BadRequest("請輸入有效的身高和體重。");
            }
            var (bmi, category) = BmiService.CalculateBmi(input.Height, input.Weight);
            return Ok(new { bmi, category });
        }
    }
}
