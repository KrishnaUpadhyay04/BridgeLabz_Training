using System;
using System.Collections.Generic;
using System.Linq;

namespace LinkedList
{
    class UserNode
    {
        public int UserID; public string Name; public int Age; public List<int> Friends; public UserNode? Next;
        public UserNode(int id,string name,int age){ UserID=id; Name=name; Age=age; Friends=new List<int>(); Next=null; }
    }

    class SocialList
    {
        private UserNode? head;
        public void AddUser(UserNode u){ if(head==null){ head=u; } else { var t=head; while(t.Next!=null) t=t.Next; t.Next=u; } }
        public UserNode? FindById(int id){ var cur=head; while(cur!=null){ if(cur.UserID==id) return cur; cur=cur.Next; } return null; }
        public UserNode? FindByName(string name){ var cur=head; while(cur!=null){ if(cur.Name.Equals(name,StringComparison.OrdinalIgnoreCase)) return cur; cur=cur.Next; } return null; }
        public void AddFriend(int a,int b){ var ua=FindById(a); var ub=FindById(b); if(ua!=null && ub!=null){ if(!ua.Friends.Contains(b)) ua.Friends.Add(b); if(!ub.Friends.Contains(a)) ub.Friends.Add(a); } }
        public void RemoveFriend(int a,int b){ var ua=FindById(a); var ub=FindById(b); ua?.Friends.Remove(b); ub?.Friends.Remove(a); }
        public List<int> MutualFriends(int a,int b){ var ua=FindById(a); var ub=FindById(b); if(ua==null||ub==null) return new List<int>(); return ua.Friends.Intersect(ub.Friends).ToList(); }
        public void DisplayFriends(int id){ var u=FindById(id); if(u==null) { Console.WriteLine("User not found"); return; } Console.WriteLine($"Friends of {u.Name}: {string.Join(',',u.Friends)}"); }
        public int CountFriends(int id){ var u=FindById(id); return u?.Friends.Count ?? 0; }
    }

    public static class SocialConnections
    {
        public static void Run()
        {
            var s = new SocialList();
            while(true)
            {
                Console.Clear(); Console.WriteLine("Social Menu: 1-AddUser 2-AddFriend 3-RemoveFriend 4-Mutual 5-DisplayFriends 6-Search 7-Count 8-Exit"); var c=Console.ReadLine(); if(string.IsNullOrWhiteSpace(c)) continue; if(c=="8") break;
                switch(c)
                {
                    case "1": Console.Write("ID Name Age: "); var ln=Console.ReadLine()?.Split(' ',StringSplitOptions.RemoveEmptyEntries); if(ln!=null && ln.Length>=3) s.AddUser(new UserNode(int.Parse(ln[0]), ln[1], int.Parse(ln[2]))); break;
                    case "2": Console.Write("A B: "); var ab=Console.ReadLine()?.Split(' '); if(ab!=null) s.AddFriend(int.Parse(ab[0]), int.Parse(ab[1])); break;
                    case "3": Console.Write("A B: "); var r=Console.ReadLine()?.Split(' '); if(r!=null) s.RemoveFriend(int.Parse(r[0]), int.Parse(r[1])); break;
                    case "4": Console.Write("A B: "); var m=Console.ReadLine()?.Split(' '); if(m!=null) Console.WriteLine(string.Join(',', s.MutualFriends(int.Parse(m[0]), int.Parse(m[1])))); break;
                    case "5": Console.Write("ID: "); var id=int.Parse(Console.ReadLine()??"0"); s.DisplayFriends(id); break;
                    case "6": Console.Write("Search by (id/name): "); var mode=Console.ReadLine(); if(mode=="id"){ Console.Write("ID: "); var u=s.FindById(int.Parse(Console.ReadLine()??"0")); Console.WriteLine(u==null?"Not found":$"Found: {u.Name}"); } else { Console.Write("Name: "); var u=s.FindByName(Console.ReadLine()??""); Console.WriteLine(u==null?"Not found":$"Found: {u.UserID}"); } break;
                    case "7": Console.Write("ID: "); var cid=int.Parse(Console.ReadLine()??"0"); Console.WriteLine(s.CountFriends(cid)); break;
                }
                Console.WriteLine("Press Enter..."); Console.ReadLine();
            }
        }
    }
}
