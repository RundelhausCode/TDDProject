using System;
using System.Text.RegularExpressions;

namespace UserService
{
    public class UserServices
    {
        public bool IsEmail(string Candidate)
        {
            string pattern = @"^[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+(?:[a-zA-Z]{2}|aero|asia|biz|cat|com|coop|edu|gov|info|int|jobs|mil|mobi|museum|name|net|org|pro|tel|travel)$";

            Regex rgx = new Regex(pattern);
            if (rgx.IsMatch(Candidate))
            {
                return true;
            }
            else
            {
                return false;
            }

            throw new NotImplementedException("Please create a test frist");
        }
        public bool IsPasswordStrong(string Candidate)
        {   //The basic expression requires at least 1 lower case, 1 upper case, 1 numeric, 1 non-word and no whitespace
            string pattern = @"^(?=(.*[a-z]){1,})(?=(.*[\d]){1,})(?=(.*[\W]){1,})(?!.*\s).{7,30}$";

            Regex rgx = new Regex(pattern);
            if (rgx.IsMatch(Candidate))
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException("Please create a test frist");
        }
    }
}
