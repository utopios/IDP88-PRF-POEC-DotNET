using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace PizzCore.Validators
{
    public class PasswordValidator : ValidationAttribute
    {

        public override bool IsValid(object? value)
        {
            var input = value?.ToString();
            ErrorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(input))
                ErrorMessage = "Password should not be empty. ";
            else
            {
                var hasNumber = new Regex(@"[0-9]{2}");
                var hasUpperLetters = new Regex(@"[A-Z]{2}");
                var hasEnoughChars = new Regex(@".{8,15}");
                var hasLowerLetters = new Regex(@"[a-z]{2}");
                var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]{2}");

                if (!hasEnoughChars.IsMatch(input))
                    ErrorMessage += "Password should not be less than 8 characters and greater than 15 characters. ";
                if (!hasLowerLetters.IsMatch(input))
                    ErrorMessage += "Password should contain at least two lower case letters. ";
                if (!hasUpperLetters.IsMatch(input))
                    ErrorMessage += "Password should contain at least two upper case letters. ";
                if (!hasNumber.IsMatch(input))
                    ErrorMessage += "Password should contain at least two numeric characters. ";
                if (!hasSymbols.IsMatch(input))
                    ErrorMessage += "Password should contain at least two special characters. ";
                if (ErrorMessage == string.Empty)
                    return true;
            }
            return false;
        }
    }
}
