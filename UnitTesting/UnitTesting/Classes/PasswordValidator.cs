using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting.Classes
{
    public class PasswordValidator
    {
        public bool IsValid(string Password)
        {
            if (Password.Length < 8) return false;

            bool hasUppercase = false, hasDigit = false;

            foreach(char character in Password)
            {
                if (char.IsUpper(character)) hasUppercase = true;

                if (char.IsDigit(character)) hasDigit = true;
            }

            return hasUppercase && hasDigit;
        }
    }
}
