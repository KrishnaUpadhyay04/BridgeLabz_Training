using MusicPlaylistManager;
using MusicPlaylistManager.DataStructures;
using MusicPlaylistManager.Models;
using NUnit.Framework;

namespace UnitTesting.Tests;

[TestFixture]
public class Tests
{
    private MainPlaylist mainPlaylist = null!;
    private PlaylistManager listManager = null!;
    private RecentlyPlayed recentlyPlayed = null!;

    [SetUp]
    public void Setup()
    {
        mainPlaylist = new MainPlaylist();
        listManager = new PlaylistManager();
        recentlyPlayed = new RecentlyPlayed();
    }

    // MAIN PLAYLIST
    [Test]
    public void AddToMainPlaylist()
    {
        mainPlaylist.AddLast(new Song("111", "Narmahat Freestyle", "Karma", "Hip-Hop",150));

        Assert.That(mainPlaylist.Head!.Song.Title, Is.EqualTo("Narmahat Freestyle"));
    }

    [Test]
    public void MainPlaylistDoesNotContainSong()
    {
        bool result = mainPlaylist.Contains("112");

        Assert.That(result, Is.False);
    }

    [Test]
    public void MainPlaylistContainsSong()
    {
        mainPlaylist.AddLast(new Song("112", "Dhundla", "Talwinder", "Hip-Hop", 160));

        bool result = mainPlaylist.Contains("112");

        Assert.That(result, Is.True);
    }

    [Test]
    public void ReorderingSongToHead()
    {
        mainPlaylist.AddLast(new Song("111", "Google Pay", "Karma", "Hip-Hop", 175));

        mainPlaylist.AddLast(new Song("112", "Dhundla", "Talwinder", "Hip-Hop", 160));

        mainPlaylist.AddLast(new Song("113", "Mast Magan", "Arijit Singh", "Love", 147));

        mainPlaylist.AddLast(new Song("114", "Shaayad", "Taba Chake", "Calming", 200));

        mainPlaylist.Move("113", 0);

        Assert.That(mainPlaylist.Head.Song.SongId, Is.EqualTo("113"));
    }

    [Test]
    public void ClearMainPlaylist()
    {
        mainPlaylist.AddLast(new Song("111", "Google Pay", "Karma", "Hip-Hop", 175));

        mainPlaylist.AddLast(new Song("112", "Dhundla", "Talwinder", "Hip-Hop", 160));

        mainPlaylist.AddLast(new Song("113", "Mast Magan", "Arijit Singh", "Love", 147));

        mainPlaylist.Clear();

        Assert.That(mainPlaylist.Head, Is.Null);
        Assert.That(mainPlaylist.Count, Is.EqualTo(0));
    }



    // LIBRARY
    [Test]
    public void LibraryContainsSongsWithUniqueId()
    {
        listManager.AddSong(new Song("111", "Narmahat Freestyle", "Karma", "Hip-Hop", 150));

        Assert.Throws<InvalidOperationException>(() => listManager.AddSong(new Song("111", "Channa Mereya", "Arijit Singh", "Love", 165)));
    }

    [Test]
    public void GetSongByIdFromLibrary()
    {
        listManager.AddSong(new Song("111", "Google Pay", "Karma", "Hip-Hop", 175));

        Song? song = listManager.GetSongById("111");

        Assert.That(song, Is.Not.Null);
        Assert.That(song!.SongId, Is.EqualTo("111"));
    }


   
    // RECENTLY PLAYED
    [Test]
    public void HistoryClearedFromRecentlyPlayed()
    {
        recentlyPlayed.AddAtHead(new Song("113", "Mast Magan", "Arijit Singh", "Love", 147));

        recentlyPlayed.Clear();

        Assert.That(recentlyPlayed.ToList(), Is.Empty);
    }

    [Test]
    public void SingleSongDeletedFromHistory()
    {
        recentlyPlayed.AddAtHead(new Song("111", "Google Pay", "Karma", "Hip-Hop", 175));

        recentlyPlayed.AddAtHead(new Song("112", "Dhundla", "Talwinder", "Hip-Hop", 160));

        recentlyPlayed.DeleteFromHistory();

        List<Song> history = recentlyPlayed.ToList();

        Assert.That(history[0].SongId, Is.EqualTo("111"));
    }

    
    // INTEGRATION
    [Test]
    public void AddSongToManagerAndPlaylist()
    {
        Song song = new("111", "Google Pay", "Karma", "Hip-Hop", 175);

        listManager.AddSong(song);
        listManager.AddToPlaylist("111");

        Assert.That(listManager.GetPlaylist().Count, Is.EqualTo(1));
    }

    [Test]
    public void PlayNextHasPriorityOverMainPlaylist()
    {
        listManager.AddSong(new Song("111", "Song 1", "Artist 1", "Pop", 100));

        listManager.AddSong(new Song("112", "Song 2", "Artist 2", "Rock", 120));

        listManager.AddToPlaylist("111");

        listManager.PlayNext("112");

        Song? played = listManager.Play();

        Assert.That(played!.SongId, Is.EqualTo("112"));
    }

    [Test]
    public void PlayedSongIsAddedToRecentlyPlayed()
    {
        listManager.AddSong(new Song("111", "Song 1", "Artist 1", "Pop", 100));

        listManager.AddToPlaylist("111");

        Song? played = listManager.Play();

        List<Song> history =listManager.GetRecentlyPlayed();

        Assert.That(history.Count, Is.EqualTo(1));
        Assert.That(history[0].SongId, Is.EqualTo(played!.SongId));
    }
}