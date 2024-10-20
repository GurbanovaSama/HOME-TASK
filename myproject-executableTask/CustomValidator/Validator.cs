using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CustomValidator
{
    public class Validator
    {
        public bool ValidateUserName(string userName)
        {
            return userName.Length >= 2;
        }

        public bool ValidateName(string name)
        {
            return name.Length >= 2;
        }

        public bool ValidateSurname(string surname)
        {
            return surname.Length >= 2;
        }

        public bool ValidatePassword(string password)
        {
            bool min8Chars = password.Length >= 8;
            bool number = password.Any(char.IsDigit);
            bool symbolChar = Regex.IsMatch(password, @"[^a-zA-Z0-9]");
            bool upperChar = password.Any(char.IsUpper);
            bool lowerChar = password.Any(char.IsLower);

            return min8Chars && number && symbolChar && upperChar && lowerChar;
        }

        public bool ValidateAge(byte age)
        {
            return age > 0;
        }

        public bool ValidateBirthday(DateTime birthday)
        {
            return birthday.Year > 1970;
        }


    }
}
