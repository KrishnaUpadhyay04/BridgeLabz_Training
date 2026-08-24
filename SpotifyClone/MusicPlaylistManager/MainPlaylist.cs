using MusicPlaylistManager.Models;

namespace MusicPlaylistManager.DataStructures;

public class MainPlaylist
{
    public class Node
    {
        public Song Song { get; }

        public Node? Next { get; set; }
        public Node? Previous { get; set; }

        public Node(Song song)
        {
            Song = song;
        }
    }

    public Node? Head { get; private set; }
    public Node? Current { get; private set; }

    public int Count { get; private set; }

    public bool IsEmpty => Count == 0;

    public void AddLast(Song song)
    {
        Node newNode = new(song);

        if (Head == null)
        {
            Head = newNode;

            newNode.Next = newNode;
            newNode.Previous = newNode;

            Current = newNode;
            Count = 1;

            return;
        }

        Node tail = Head.Previous!;

        newNode.Next = Head;
        newNode.Previous = tail;

        tail.Next = newNode;
        Head.Previous = newNode;

        Count++;
    }

    public bool Contains(string songId)
    {
        return FindNode(songId) != null;
    }

    public Node? FindNode(string songId)
    {
        if (Head == null) return null;

        Node current = Head;

        do
        {
            if (current.Song.SongId == songId)
                return current;

            current = current.Next!;
        }
        while (current != Head);

        return null;
    }

    public Song? FindSong(string songId)
    {
        return FindNode(songId)?.Song;
    }

    public bool Remove(string songId)
    {
        Node? node = FindNode(songId);

        if (node == null) return false;

        RemoveNode(node);

        return true;
    }

    private void RemoveNode(Node node)
    {
        if (Count == 1)
        {
            Head = null;
            Current = null;
            Count = 0;
            return;
        }

        node.Previous!.Next = node.Next;
        node.Next!.Previous = node.Previous;

        if (node == Head) Head = node.Next;

        if (node == Current) Current = node.Next;

        Count--;
    }

    public bool Move(string songId, int newIndex)
    {
        if (Count <= 1) return newIndex == 0;

        if (newIndex < 0 || newIndex >= Count) return false;

        Node? node = FindNode(songId);

        if (node == null) return false;

        List<Song> songs = ToList();

        songs.Remove(node.Song);
        songs.Insert(newIndex, node.Song);

        string? currentId = Current?.Song.SongId;

        Rebuild(songs, currentId);

        return true;
    }

    public Song? PlayNext()
    {
        if (Current == null) return null;

        Current = Current.Next!;

        return Current.Song;
    }

    public Song? PlayPrevious()
    {
        if (Current == null) return null;

        Current = Current.Previous!;

        return Current.Song;
    }

    public Song? GetCurrent()
    {
        return Current?.Song;
    }

    public List<Song> ToList()
    {
        List<Song> result = new();

        if (Head == null) return result;

        Node current = Head;

        do
        {
            result.Add(current.Song);
            current = current.Next!;
        }
        while (current != Head);

        return result;
    }

    public void Rebuild(
        List<Song> songs,
        string? currentSongId)
    {
        Head = null;
        Current = null;
        Count = 0;

        foreach (Song song in songs)
        {
            AddLast(song);
        }

        if (currentSongId != null)
        {
            Node? node = FindNode(currentSongId);

            if (node != null) Current = node;
        }
    }

    public void Clear()
    {
        Head = null;
        Current = null;
        Count = 0;
    }
}