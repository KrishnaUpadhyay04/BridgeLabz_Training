namespace RegexBasics;
using System.Text.RegularExpressions;

class ExtractCapitalizedWords
{
    public void Validate (string Text)
    {
        string Pattern = @"\b[A-Z][a-z]+\b";

        MatchCollection matches = Regex.Matches(Text, Pattern);

        foreach(var match in matches)
        {
            Console.Write(match + " ");
        }
    }
}