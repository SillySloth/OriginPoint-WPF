using System.Windows.Controls;

namespace OriginPoint_WPF.Utilities
{
    public class DataValidation
    {
        public static double ParseTextBox(TextBox textbox)
        {
            var cleanedText = textbox.Text.Replace(" ", "");
            if (double.TryParse(cleanedText, out double result))
            {
                return result;
            }
            return 0; // Default value if parsing fails
        }
    }
}
