using System.Text.RegularExpressions;

public class LastName
{
    private string lastName;

    public LastName(string lastName)
    {
        ValidateLastName(lastName);
        this.lastName = lastName;
        GetValue();
    }

    public string GetValue()
    {
        return lastName;
    }   

    private void ValidateLastName(string lastName)
    {
        if (lastName.Length < 2 || lastName.Length > 20)
        {
            throw new ArgumentException("Last name must be between 2 and 20 characters.");
        }
        if (!Regex.IsMatch(lastName, @"^[a-zA-Z]+$"))
        {
            throw new ArgumentException("Last name can only contain alphabetic characters.");
        }
    }
}