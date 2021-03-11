using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    class RegexValidation
    {
        public const string Regex_FirstName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string Regex_LastName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string Regex_Email = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        public const string Regex_MobileNumber = "^[1-9]{1}[0-9]{0,3}\\s[1-9]{1}[0-9]{9}$";
        public bool ValidateFirstName(string firstName)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(firstName, Regex_FirstName);
        }
        public bool ValidateLastName(string lastName)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(lastName, Regex_LastName);
        }
        public bool ValidateEmail(string email)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(email, Regex_Email);
        }
        public bool ValidateMobile(string mobileNum)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(mobileNum, Regex_MobileNumber);
        }
    }
}
