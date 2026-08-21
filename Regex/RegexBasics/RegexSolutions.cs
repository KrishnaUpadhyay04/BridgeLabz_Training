namespace RegexBasics;

using System.Text.RegularExpressions;

static class RegexSolutions
{
    public static IEnumerable<string> ExtractLinks(string text)
    {
        return Regex.Matches(text, @"https?://[^\s)\]]+")
            .Select(match => match.Value.TrimEnd('.', ',', ';'));
    }

    public static string ReplaceMultipleSpaces(string text)
    {
        return Regex.Replace(text, @"\s+", " ").Trim();
    }

    public static string CensorBadWords(string text, IEnumerable<string> badWords)
    {
        string words = string.Join("|", badWords.Select(Regex.Escape));
        return Regex.Replace(text, $@"\b({words})\b", "****", RegexOptions.IgnoreCase);
    }

    public static bool IsValidIpAddress(string address)
    {
        string[] parts = address.Split('.');
        return parts.Length == 4 && parts.All(part =>
            part.Length > 0 && part.Length <= 3 &&
            int.TryParse(part, out int value) && value is >= 0 and <= 255);
    }

    public static bool IsValidCreditCard(string cardNumber)
    {
        return Regex.IsMatch(cardNumber, @"^(4|5)\d{15}$");
    }

    public static IEnumerable<string> ExtractProgrammingLanguages(string text)
    {
        string[] languages = { "JavaScript", "Java", "Python", "Go", "C#", "C++" };
        string pattern = $@"\b(?:{string.Join("|", languages.Select(Regex.Escape))})\b";
        return Regex.Matches(text, pattern, RegexOptions.IgnoreCase)
            .Select(match => match.Value);
    }

    public static IEnumerable<string> ExtractCurrencyValues(string text)
    {
        return Regex.Matches(text, @"\$\s*(\d+(?:\.\d{2})?)")
            .Select(match => match.Groups[1].Value);
    }

    public static IEnumerable<string> FindRepeatingWords(string text)
    {
        return Regex.Matches(text, @"\b\w+\b", RegexOptions.IgnoreCase)
            .Select(match => match.Value)
            .GroupBy(word => word, StringComparer.OrdinalIgnoreCase)
            .Where(group => group.Count() > 1)
            .Select(group => group.First());
    }

    public static bool IsValidSsn(string ssn)
    {
        return Regex.IsMatch(ssn, @"^\d{3}-\d{2}-\d{4}$");
    }
}