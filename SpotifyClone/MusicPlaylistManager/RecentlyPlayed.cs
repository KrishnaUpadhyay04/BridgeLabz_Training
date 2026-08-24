using System.Dynamic;
using MusicPlaylistManager.Models;
namespace MusicPlaylistManager.DataStructures;


public class RecentlyPlayed
{
    class ListNode
    {
        public Song song { get; private set; }

        public ListNode next;

        public ListNode(Song song)
        {
            this.song = song;
            next = null;
        }
    }
    private ListNode head;

    public int Count { get; private set; }

    public void AddAtHead(Song song)
    {
        ListNode newHead = new ListNode(song);
        newHead.next = head;
        head = newHead;

        Count++;
    }


    public void DeleteFromHistory()
    {
        if(head == null) return;
        head = head.next;
        Count--;
    }

    public void ClearHistory()
    {
        head = null;
        Count = 0;
    }

    public void DisplaySongsHistory()
    {
        if(head == null)
        {
            Console.WriteLine("No Songs Found!");
            return;
        }

        ListNode temp = head;

        while(temp != null)
        {
            temp.song.DisplayDetails();
            temp = temp.next;
        }
    }

    public List<Song> ToList()
    {
        ListNode temp = head;
        List<Song> songs = new();
        while(temp != null)
        {
            songs.Add(temp.song);
            temp = temp.next;
        }

        return songs;
    }

    public void Clear()
    {
        head.next = null;
        head = null;
    }
}