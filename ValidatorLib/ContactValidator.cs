using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidatorLib
{
    public static class ContactValidator
    {
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber)) return false;

            string pattern = "^\\+?[0-9\\-\\s]{7,15}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }


        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;

            string pattern = "^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
