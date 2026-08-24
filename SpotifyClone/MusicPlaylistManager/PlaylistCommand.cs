namespace MusicPlaylistManager.Playlist;

public class PlaylistCommand
{
    public string Description { get; }

    public PlaylistSnapshot Before { get; }
    public PlaylistSnapshot After { get; }

    public PlaylistCommand(string description, PlaylistSnapshot before, PlaylistSnapshot after)
    {
        Description = description;
        Before = before;
        After = after;
    }
}