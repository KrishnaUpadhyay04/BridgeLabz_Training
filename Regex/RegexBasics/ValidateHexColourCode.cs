namespace RegexBasics;
using System.Text.RegularExpressions;

class ValidateHexColourCode
{
    public void Validate(string Code)
    {
        bool Result = Regex.IsMatch(Code, @"^#[A-Fa-f0-9]{6}$");

        if(Result) Console.WriteLine("Valid Hex Code");

        else Console.WriteLine("Invalid Hex Code");
    }
}