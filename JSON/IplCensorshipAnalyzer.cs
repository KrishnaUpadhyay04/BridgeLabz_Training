using System.Text.Json;

public static class IplCensorshipAnalyzer
{
    private static readonly JsonSerializerOptions Options = new() { WriteIndented = true, PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower };

    public static string MaskTeamName(string teamName)
    {
        string[] words = teamName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (words.Length <= 1) return "***";
        if (words.Length == 2) return $"{words[0]} ***";
        return $"{words[0]} *** {string.Join(' ', words.Skip(2))}";
    }

    public static List<IplMatch> Censor(IEnumerable<IplMatch> matches)
    {
        return matches.Select(match =>
        {
            string maskedTeam1 = MaskTeamName(match.Team1);
            string maskedTeam2 = MaskTeamName(match.Team2);
            Dictionary<string, int> scores = new();
            foreach ((string team, int score) in match.Score)
                scores[team == match.Team1 ? maskedTeam1 : team == match.Team2 ? maskedTeam2 : MaskTeamName(team)] = score;
            return new IplMatch
            {
                MatchId = match.MatchId, Team1 = maskedTeam1, Team2 = maskedTeam2,
                Score = scores, Winner = match.Winner == match.Team1 ? maskedTeam1 : match.Winner == match.Team2 ? maskedTeam2 : MaskTeamName(match.Winner),
                PlayerOfMatch = "REDACTED"
            };
        }).ToList();
    }

    public static void JsonToCensoredJson(string inputPath, string outputPath)
    {
        List<IplMatch> matches = JsonSerializer.Deserialize<List<IplMatch>>(File.ReadAllText(inputPath), Options) ?? new();
        File.WriteAllText(outputPath, JsonSerializer.Serialize(Censor(matches), Options));
    }

    public static void CsvToCensoredCsv(string inputPath, string outputPath)
    {
        string[] lines = File.ReadAllLines(inputPath);
        if (lines.Length == 0) return;
        List<string> output = new() { lines[0] };
        foreach (string line in lines.Skip(1).Where(line => !string.IsNullOrWhiteSpace(line)))
        {
            string[] columns = line.Split(',');
            if (columns.Length < 7) continue;
            string originalTeam1 = columns[1];
            string originalTeam2 = columns[2];
            string originalWinner = columns[5];
            columns[1] = MaskTeamName(columns[1]); columns[2] = MaskTeamName(columns[2]);
            columns[5] = originalWinner == originalTeam1 ? columns[1] : originalWinner == originalTeam2 ? columns[2] : MaskTeamName(originalWinner);
            columns[6] = "REDACTED";
            output.Add(string.Join(',', columns));
        }
        File.WriteAllLines(outputPath, output);
    }

    public static void Run(string jsonInput, string jsonOutput, string csvInput, string csvOutput)
    {
        JsonToCensoredJson(jsonInput, jsonOutput);
        CsvToCensoredCsv(csvInput, csvOutput);
        Console.WriteLine($"Censored files created: {jsonOutput}, {csvOutput}");
    }
}
