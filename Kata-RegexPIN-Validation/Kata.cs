using System.Text.RegularExpressions;

namespace Kata_RegexPIN_Validation
{
    public static class Kata
    {
        public static bool RegexMatch(int pin)
        {
            var pattern = @"^\d{4}$|^\d{6}$";
            var regex = new Regex(pattern);
            return regex.IsMatch(pin.ToString());
        }
    }
}