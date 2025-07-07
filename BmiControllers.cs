using Microsoft.AspNetCore.Mvc;

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
            double bmi = weight / Math.Pow(height / 100, 2);
            string category = "";
            if (bmi < 18.5)
            {
                category = "體重過輕";
            }
            else if (bmi < 24)
            {
                category = "正常範圍";
            }
            else if (bmi < 27)
            {
                category = "過重";
            }
            else if (bmi < 30)
            {
                category = "輕度肥胖";
            }
            else if (bmi < 35)
            {
                category = "中度肥胖";
            }
            else
            {
                category = "重度肥胖";
            }
            return Ok(new { bmi = bmi.ToString("F2"), category });
        }

        [HttpPost]
        public IActionResult Post([FromBody] BmiInput input)
        {
            if (input.Height <= 0 || input.Weight <= 0)
            {
                return BadRequest("請輸入有效的身高和體重。");
            }
            double bmi = input.Weight / Math.Pow(input.Height / 100, 2);
            string category = "";
            if (bmi < 18.5)
            {
                category = "體重過輕";
            }
            else if (bmi < 24)
            {
                category = "正常範圍";
            }
            else if (bmi < 27)
            {
                category = "過重";
            }
            else if (bmi < 30)
            {
                category = "輕度肥胖";
            }
            else if (bmi < 35)
            {
                category = "中度肥胖";
            }
            else
            {
                category = "重度肥胖";
            }
            return Ok(new { bmi = bmi.ToString("F2"), category });
        }
    }
}
