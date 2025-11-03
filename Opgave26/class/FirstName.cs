using System.Text.RegularExpressions;

namespace Opgave26
{

    public class FirstName
    {
        private string firstName;

        public FirstName(string firstName)
        {
            ValidateFirstName(firstName);
            this.firstName = firstName;
            GetValue();
        }

        public string GetValue()
        {
            return firstName;
        }

        private void ValidateFirstName(string firstName)
        {
            if (firstName == null)
            {
                throw new ArgumentNullException("First name cannot be null.");
            }
            if (firstName.Length < 2 || firstName.Length > 20)
            {
                throw new ArgumentException("First name must be between 2 and 20 characters.");
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(firstName, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentException("First name can only contain alphabetic characters.");
            }
        }

    }
}