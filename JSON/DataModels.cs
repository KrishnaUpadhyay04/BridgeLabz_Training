public sealed class Student
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public List<string> Subjects { get; set; } = new();
}

public sealed class Car
{
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int Year { get; set; }
}

public sealed class UserRecord
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Email { get; set; } = string.Empty;
}

public sealed class IplMatch
{
    public int MatchId { get; set; }
    public string Team1 { get; set; } = string.Empty;
    public string Team2 { get; set; } = string.Empty;
    public Dictionary<string, int> Score { get; set; } = new();
    public string Winner { get; set; } = string.Empty;
    public string PlayerOfMatch { get; set; } = string.Empty;
}
