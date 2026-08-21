using System.Text.RegularExpressions;

class ExtractDates
{
    public void Solution(string Text)
    {
        MatchCollection matches = Regex.Matches(Text, @"\b\d{2}/\d{2}/\d{4}\b");

        foreach(Match match in matches)
        {
            Console.WriteLine(match);
        }
    }
}