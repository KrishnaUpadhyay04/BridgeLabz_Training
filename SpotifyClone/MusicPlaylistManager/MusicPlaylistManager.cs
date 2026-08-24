using MusicPlaylistManager.DataStructures;
using MusicPlaylistManager.Models;
using MusicPlaylistManager.Playlist;

namespace MusicPlaylistManager;

public class PlaylistManager
{
    private Dictionary<string, Song> library = new();

    private MainPlaylist playlist = new();

    private Queue<Song> playNextQueue = new();

    private RecentlyPlayed recentlyPlayed = new();

    private Stack<PlaylistCommand> undoStack = new();

    private Stack<PlaylistCommand> redoStack = new();

    // Song Library

    public void AddSong(Song song)
    {
        if (library.ContainsKey(song.SongId)) throw new InvalidOperationException($"Song ID '{song.SongId}' already exists.");

        library.Add(song.SongId, song);
    }

    public Song? GetSongById(string songId)
    {
        library.TryGetValue(songId, out Song? song);
        return song;
    }

    public int LibraryCount => library.Count;

    // Playlist

    public void AddToPlaylist(string songId)
    {
        Song song = GetRequiredSong(songId);

        PlaylistSnapshot before = CreateSnapshot();

        playlist.AddLast(song);

        PlaylistSnapshot after = CreateSnapshot();

        RecordCommand("Add song to playlist", before, after);
    }

    public bool RemoveSong(string songId)
    {
        PlaylistSnapshot before = CreateSnapshot();

        bool removed = playlist.Remove(songId);

        if (!removed) return false;

        PlaylistSnapshot after = CreateSnapshot();

        RecordCommand("Remove song from playlist", before, after);

        return true;
    }

    public bool MoveSong(string songId, int newIndex)
    {
        PlaylistSnapshot before = CreateSnapshot();

        bool moved = playlist.Move(songId, newIndex);

        if (!moved) return false;

        PlaylistSnapshot after = CreateSnapshot();

        RecordCommand("Move song", before, after);

        return true;
    }

    public List<Song> GetPlaylist()
    {
        return playlist.ToList();
    }

    public Song? GetCurrentSong()
    {
        return playlist.GetCurrent();
    }

    // PLAY NEXT

    public void PlayNext(string songId)
    {
        Song song = GetRequiredSong(songId);

        playNextQueue.Enqueue(song);
    }

    public int PlayNextCount => playNextQueue.Count;


    // PLAYBACK

    public Song? Play()
    {
        Song? song;

        if (playNextQueue.Count > 0)
        {
            song = playNextQueue.Dequeue();
        }
        else
        {
            song = playlist.PlayNext();
        }

        if (song == null) return null;

        AddToHistory(song);

        return song;
    }

    public Song? PlayPrevious()
    {
        Song? song = playlist.PlayPrevious();

        if (song != null) AddToHistory(song);

        return song;
    }

    // RECENT HISTORY

    private void AddToHistory(Song song)
    {
        recentlyPlayed.AddAtHead(song);
    }

    public List<Song> GetRecentlyPlayed()
    {
        return recentlyPlayed.ToList();
    }

    public void ClearHistory()
    {
        recentlyPlayed.Clear();
    }

    // UNDO / REDO

    private PlaylistSnapshot CreateSnapshot()
    {
        return new PlaylistSnapshot(playlist.ToList(), playlist.GetCurrent()?.SongId);
    }

    private void RestoreSnapshot(PlaylistSnapshot snapshot)
    {
        playlist.Rebuild(snapshot.Songs, snapshot.CurrentSongId);
    }

    private void RecordCommand(string description, PlaylistSnapshot before, PlaylistSnapshot after)
    {
        undoStack.Push(new PlaylistCommand(description, before, after));

        // New modification after Undo clears Redo.
        redoStack.Clear();
    }

    public bool Undo()
    {
        if (undoStack.Count == 0) return false;

        PlaylistCommand command = undoStack.Pop();

        RestoreSnapshot(command.Before);

        redoStack.Push(command);

        return true;
    }

    public bool Redo()
    {
        if (redoStack.Count == 0) return false;

        PlaylistCommand command = redoStack.Pop();

        RestoreSnapshot(command.After);

        undoStack.Push(command);

        return true;
    }

    public int UndoCount => undoStack.Count;
    public int RedoCount => redoStack.Count;


    // SORTING
    public List<Song> SortByTitle()
    {
        return library.Values.OrderBy(song => song.Title, StringComparer.OrdinalIgnoreCase).ToList();
    }

    public List<Song> SortByArtist()
    {
        return library.Values.OrderBy(song => song.Artist, StringComparer.OrdinalIgnoreCase).ToList();
    }

    public List<Song> SortByDuration()
    {
        return library.Values.OrderBy(song => song.DurationSeconds).ToList();
    }



    // BINARY SEARCH
    public Song? BinarySearchByTitle(string title)
    {
        List<Song> songs = SortByTitle();

        int left = 0;
        int right = songs.Count - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            int comparison = string.Compare(songs[mid].Title, title, StringComparison.OrdinalIgnoreCase);

            if (comparison == 0) return songs[mid];

            if (comparison < 0) left = mid + 1;

            else right = mid - 1;
        }

        return null;
    }


    // GENRE SEARCH

    public List<Song> GenreSearch(string Genre)
    {
        if (string.IsNullOrWhiteSpace(Genre)) return new List<Song>();

        return library.Values.Where(song => song.Genre.Contains(Genre, StringComparison.OrdinalIgnoreCase)).ToList();
    }



    // HELPERS
    private Song GetRequiredSong(string songId)
    {
        Song? song = GetSongById(songId);

        if (song == null) throw new KeyNotFoundException($"Song '{songId}' was not found.");

        return song;
    }
}