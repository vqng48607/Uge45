using System;
using System.Text.RegularExpressions;

public class CprNumber
{
    private string cprNumber;

    public CprNumber(string cprNumber)
    {
        ValidateCpr(cprNumber);
        this.cprNumber = cprNumber;
        GetValue();
    }

    public string GetValue()
    {
        return cprNumber;
    }

    private void ValidateCpr(string cpr)
    {
        if (string.IsNullOrWhiteSpace(cpr))
            throw new ArgumentException("CPR må ikke være tomt.");

        if (!Regex.IsMatch(cpr, @"^\d{10}$"))
            throw new ArgumentException("CPR skal bestå af 10 cifre.");

        int dag = int.Parse(cpr.Substring(0, 2));
        int måned = int.Parse(cpr.Substring(2, 2));

        if (dag < 1 || dag > 31)
            throw new ArgumentException("Ugyldig dag i CPR.");
        if (måned < 1 || måned > 12)
            throw new ArgumentException("Ugyldig måned i CPR.");
    }
}