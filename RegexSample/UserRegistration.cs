using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class UserRegister
    {
        // Static Variable
        public static string firstNamePattern = "^[A-Z]{1}[a-z]{2}";
        public static string lastNamePattern = "^[A-Z]{1}[a-z]{2}";
        public static string emailPattern = "^[a-zA-z]{3}([.]*[a-zA-Z])+[@]([a-z]{3,})+([.][a-z]{2,3})*$";

        //Method to Validate First Name
        public static string ValidatePattern(string userInput, string pattern)
        {
            if (Regex.IsMatch(userInput, pattern))
                return "true";
            else
                return "false";
        }
        //Method to Validate First Name
        public static string ValidateFirstName(string name)
        {
            var firstNameMatch = ValidatePattern(name, firstNamePattern);
            return firstNameMatch;
        }
        //Method to Validate Last Name
        public static string ValidateLastName(string name)
        {
            var lastNameMatch = ValidatePattern(name, lastNamePattern);
            return lastNameMatch;
        }
        //Method to Validate Mobile Nuber
        public static string ValidateEmailID(string mail)
        {
            var mailMatch = ValidatePattern(mail, emailPattern);
            return mailMatch;
        }
    
    }
}