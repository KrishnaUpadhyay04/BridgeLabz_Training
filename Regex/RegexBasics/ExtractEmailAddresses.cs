namespace RegexBasics;
using System.Text.RegularExpressions;

class ExtractEmailAddresses
{
    public void Validate(string Mail)
    {
        string Pattern = @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}";

        MatchCollection matches = Regex.Matches(Mail, Pattern);

        foreach(var match in matches)
        {
            Console.WriteLine(match);
        }
    }
}

// string pattern = @"^(https?://)?(www\.)?[\w\-]+(\.[\w\-]+)+(/[\w\-./?%&=]*)?$";