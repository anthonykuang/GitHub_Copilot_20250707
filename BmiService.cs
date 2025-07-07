namespace HOL_GitHub_Copilot_HTML.Services
{
    public class BmiService
    {
        public static (string bmi, string category) CalculateBmi(double height, double weight)
        {
            double bmiValue = weight / Math.Pow(height / 100, 2);
            string category = "";
            if (bmiValue < 18.5)
            {
                category = "體重過輕";
            }
            else if (bmiValue < 24)
            {
                category = "正常範圍";
            }
            else if (bmiValue < 27)
            {
                category = "過重";
            }
            else if (bmiValue < 30)
            {
                category = "輕度肥胖";
            }
            else if (bmiValue < 35)
            {
                category = "中度肥胖";
            }
            else
            {
                category = "重度肥胖";
            }
            return (bmiValue.ToString("F2"), category);
        }
    }
}
