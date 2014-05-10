using System.Text.RegularExpressions;

namespace SwedishValidation
{
    public class BeAValid
    {
        public static bool PhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^(([+]\d{2}[ ][1-9]\d{0,2}[ ])|([0]\d{1,3}[-]))((\d{2}([ ]\d{2}){2})|(\d{3}([ ]\d{3})*([ ]\d{2})+))$");
        }

        public static bool MobilePhoneNumber(string mobilePhoneNumber)
        {
            return PhoneNumber(mobilePhoneNumber);
        }

        public static bool SocialSecurityNumber(string socialSecurityNumber)
        {
            return true;
        }
    }
}