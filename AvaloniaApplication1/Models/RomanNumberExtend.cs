using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace AvaloniaApplication1.Models
{
    public class RomanNumberExtend: RomanNumber
    {
        public ushort UshortValue() => this.number;
        public RomanNumberExtend(string num) : base(romanToInt(num)) { }
        public RomanNumberExtend(ushort n) : base(n) { }
        private static ushort value(char r)
        {
            try
            {
                return dict.FirstOrDefault(x => x.Value == r.ToString()).Key;
            }
            catch (Exception e)
            {
                throw new RomanNumberException();
            }

        }

        private static ushort romanToInt(string s)
        {
            if (!RomanNumberValidator.Validate(s)) 
            {
                throw new RomanNumberException();
            }
            
            ushort total = 0;
            for (int i = 0; i < s.Length; i++)
            {
                ushort s1 = value(s[i]);
                if (i + 1 < s.Length)
                {
                    ushort s2 = value(s[i + 1]);
                    if (s1 >= s2)
                    {
                        total = (ushort)(total + s1);
                    }
                    else
                    {
                        total = (ushort)(total - s1);
                    }
                }
                else
                {
                    total = (ushort)(total + s1);
                }
            }
            return total;
        }

    }
   
}