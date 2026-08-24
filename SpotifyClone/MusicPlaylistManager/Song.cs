namespace MusicPlaylistManager.Models;

public class Song
{
    public string SongId { get; private set; }
    public string Title { get; private set; }
    public string Artist { get; private set; }
    public string Genre { get; private set; }
    public int DurationSeconds { get; private set; }

    public Song(string SongId, string Title, string Artist, string Genre, int DurationSeconds)
    {
        this.SongId = SongId;
        this.Title = Title;
        this.Artist = Artist;
        this.Genre = Genre;
        this.DurationSeconds = DurationSeconds;
    }
    public void DisplayDetails()
    {
        Console.WriteLine($"Song Id : {SongId}\nTitle   : {Title}\nArtist  : {Artist}\nGenre   : {Genre}\n Runtime : {DurationSeconds / 60}:{DurationSeconds % 60}");
    }
}