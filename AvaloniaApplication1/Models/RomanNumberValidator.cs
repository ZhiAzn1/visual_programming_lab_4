using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AvaloniaApplication1.Models
{
    public static class RomanNumberValidator
    {
        private static Regex regexValidator = new Regex("^M{0,3}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$");
        public static bool Validate(string number)
        {
            return regexValidator.IsMatch(number);
        }
    }
}
