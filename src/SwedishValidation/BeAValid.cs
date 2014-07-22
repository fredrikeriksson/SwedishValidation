using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SwedishValidation
{
    public class BeAValid
    {
        public static bool PhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber.Replace("-", "").Replace(" ", ""), ValidationRegEx.PhoneNumber);
        }

        public static bool MobilePhoneNumber(string mobilePhoneNumber)
        {
            return PhoneNumber(mobilePhoneNumber);
        }

        public static bool SocialSecurityNumber(string socialSecurityNumber)
        {
            if (ValidateWithRegex(socialSecurityNumber))
                return false;
            var onlyNumbersString = ReturnOnlyWithNumbers(socialSecurityNumber);
            var numbers = StringToNumberList(onlyNumbersString);
            var calculatedNumbers = GetCalculatedNumbers(numbers);
            var numbersSplitIfOverTen = SplitNumbersIfGreaterThan10(calculatedNumbers);
            var checksumNumber = CalculateChecksumNumber(numbersSplitIfOverTen);

            return checksumNumber == numbers[9];
        }

        /// <summary>
        /// Validate the string to comply with normal Social Security Number standards e.g. 750231-0241
        /// </summary>
        /// <param name="socialSecurityNumber"></param>
        /// <returns></returns>
        private static bool ValidateWithRegex(string socialSecurityNumber)
        {
            return !Regex.IsMatch(socialSecurityNumber, ValidationRegEx.SocialSecurityNumber);
        }

        /// <summary>
        /// Remove plus and minus signs.
        /// </summary>
        /// <param name="socialSecurityNumber"></param>
        /// <returns></returns>
        private static string ReturnOnlyWithNumbers(string socialSecurityNumber)
        {
            return socialSecurityNumber.Replace("-", "").Replace("+", "");
        }

        /// <summary>
        /// Get each number in the string as list of int
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static List<int> StringToNumberList(string str)
        {
            return str.Select(t => t.ToString()).Select(int.Parse).ToList();
        }

        /// <summary>
        /// Gets the calculated numbers by.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        private static IEnumerable<int> GetCalculatedNumbers(IEnumerable<int> numbers)
        {
            //skip the last and do the alternating multiplied by two or one.
            return numbers.Take(9).Select((number, i) => i % 2 == 0 ? number * 2 : number * 1);
        }
        /// <summary>
        /// Make sure each number is not over 10, in that case split into two, e.g. 14 is turned into 1, 4.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        private static IEnumerable<int> SplitNumbersIfGreaterThan10(IEnumerable<int> numbers)
        {
            return numbers.SelectMany(number => number.ToString()).Select(s => int.Parse(s.ToString()));
        }

        /// <summary>
        /// Calculates the checksum
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        private static int CalculateChecksumNumber(IEnumerable<int> numbers)
        {
            return 10 - (numbers.Sum() % 10);
        }
    }
}