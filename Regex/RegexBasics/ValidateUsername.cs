namespace RegexBasics;

using System.Text.RegularExpressions;
class ValidateUsername
{
    public void Validate(string Name)
    {
        string pattern = @"^[a-zA-Z][a-zA-Z0-9_]{4,14}$";

        if(Regex.IsMatch(Name, pattern)) Console.WriteLine("Valid Username");

        else Console.WriteLine("Invalid Username");
    }
}