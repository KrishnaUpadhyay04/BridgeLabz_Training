namespace RegexBasics;
using System.Text.RegularExpressions;
class ValidateLicensePlateNumber
{
    public void Validate(string NumberPlate)
    {
        string Pattern = @"^[A-Z]{2}\d{4}$";

        if(Regex.IsMatch(NumberPlate, Pattern)) Console.WriteLine("Valid Number Plate.");

        else Console.WriteLine("Invalid Number Plate");
    }
}