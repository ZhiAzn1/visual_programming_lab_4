using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AvaloniaApplication1.Models
{
    public static class RomanNumberCalculator
    {
        static char[] separators = { '+', '-', '*', '/' };
        private static string[] separateInput(string input)
        {
            return input.Split(separators);
        }
        public static RomanNumberExtend Calculate(string input)
        {
            var splittedInputByOperands = Regex.Split(input, @"([*()\^\/]|(?<!E)[\+\-])");
            

            string output = "";
            foreach (var element in splittedInputByOperands)
            {
                if(!separators.Contains(element[0]))
                {
                    if(!RomanNumberValidator.Validate(element))
                    {
                        throw new RomanNumberException();
                    }

                    output += (new RomanNumberExtend(element)).UshortValue().ToString(); 

                } else
                {
                    output += element;
                }

            }
            DataTable dt = new DataTable();

            return new RomanNumberExtend(Convert.ToUInt16(dt.Compute(output, "")));
        }
    }
}
