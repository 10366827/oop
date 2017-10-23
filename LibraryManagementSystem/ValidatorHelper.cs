using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace LibraryManagementSystem
{
    //  Help validate some input
    static class ValidatorHelper
    {
        public static bool IsLettersOnly(string input)
        {
            foreach (char c in input)
                if (!Char.IsLetter(c))
                    return false;
            return true;
        }

        public static bool IsLettersOrNumbersOnly(string input)
        {
            foreach (char c in input)
                if (!Char.IsLetterOrDigit(c))
                    return false;
            return true;
        }

        public static bool IsNumbersOnly(string input)
        {
            int tmp;
            return int.TryParse(input, out tmp);
        }

        //  Checks for valid PPSN
        public static bool IsValidPPSN(string input)
        {
            //  must be length 9
            if (input.Length != 9)
                return false;
            //  first 7 characters must be numbers
            if (!IsNumbersOnly(input.Substring(0, 7)))
                return false;
            //  8th characters must be a letter
            if (!Char.IsLetter(input[7]))
                return false;
            //  9th character is either a letter or a whitespace
            return Char.IsLetter(input[8]) || Char.IsWhiteSpace(input[8]);
        }
        
        //  Not a full valid ISBN check, just a quick one
        public static bool MeetsSlimlinedISBNRequirements(string input)
        {
            bool validLength = input.Length == 10 || input.Length == 13;
            return validLength && (input.Count(x => Char.IsNumber(x) || x == '-' || x == ' ') == input.Length);
        }

        public static bool IsLettersOrWhitespaceOnly(string input)
        {
            foreach (char c in input)
                if (!Char.IsLetter(c) || !Char.IsWhiteSpace(c))
                    return false;
            return true;
        }
        
        public static bool IsEmailValid(string email)
        {
            try
            {
                new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
