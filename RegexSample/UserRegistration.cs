using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexSample
{
    class UserRegistration
    {
        public static string regex = "^[A-Z]{1}[a-z]{2}";

        public bool validateString(string sample)
        {
            return Regex.IsMatch(sample, regex);
        }
    }
}
