using MusicPlaylistManager;
using MusicPlaylistManager.Models;

PlaylistManager player = new();

player.AddSong(new Song("111", "Google Pay", "Karma", "Hip-Hop", 175));
player.AddSong(new Song("112", "Dhundla", "Talwinder", "Hip-Hop", 160));
player.AddSong(new Song("113", "Mast Magan", "Arijit Singh", "Love", 147));
player.AddSong(new Song("114", "Shaayad", "Taba Chake", "Calming", 200));

player.AddToPlaylist("111");
player.AddToPlaylist("114");
player.GetRecentlyPlayed();

player.PlayNext("113");
player.PlayNext("112");

player.Play();