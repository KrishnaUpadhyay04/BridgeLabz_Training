using MusicPlaylistManager.Models;

namespace MusicPlaylistManager.Playlist;

public class PlaylistSnapshot
{
    public List<Song> Songs { get; }
    public string? CurrentSongId { get; }

    public PlaylistSnapshot(IEnumerable<Song> songs, string? currentSongId)
    {
        Songs = songs.ToList();
        CurrentSongId = currentSongId;
    }
}