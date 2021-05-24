using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GC_Lab16
{
    class Validation
    {
        public static bool StringValidator(string input)
        {
            if (String.IsNullOrWhiteSpace(input) || input.Any(char.IsDigit))
            {
               return true;
            }
            else 
                return false;
        }

        public static bool NumValidator(string input)
        {
            bool result;
            double a;

            result = double.TryParse(input, out a);

            if (!result)
            {
                return true;
            }
            else
                return false;
        }
    }
}
