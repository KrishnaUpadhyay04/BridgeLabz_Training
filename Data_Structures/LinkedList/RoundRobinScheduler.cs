using System;
using System.Collections.Generic;

namespace LinkedList
{
    class ProcessNode
    {
        public string PID; public int Burst; public int Priority; public ProcessNode? Next;
        public ProcessNode(string pid,int burst,int priority){ PID=pid;Burst=burst;Priority=priority;Next=null; }
    }

    class CircularProcessList
    {
        private ProcessNode? head; private ProcessNode? tail;
        public void AddAtEnd(ProcessNode p){ if(head==null){ head=tail=p; p.Next=head; } else { tail!.Next=p; p.Next=head; tail=p; } }
        public void RemoveById(string id){ if(head==null) return; if(head.PID==id){ if(head==tail){ head=tail=null; } else { head=head.Next; tail!.Next=head; } return; } var cur=head; while(cur!.Next!=head){ if(cur.Next!.PID==id){ if(cur.Next==tail) tail=cur; cur.Next=cur.Next.Next; return;} cur=cur.Next; } }
        public void Display(){ if(head==null) { Console.WriteLine("Empty"); return;} var cur=head; do{ Console.WriteLine($"{cur.PID}: Burst={cur.Burst} Pri={cur.Priority}"); cur=cur.Next!; } while(cur!=head); }
        public List<ProcessNode> ToList(){ var res=new List<ProcessNode>(); if(head==null) return res; var cur=head; do{ res.Add(cur); cur=cur.Next!; } while(cur!=head); return res; }
        public ProcessNode? Head=>head;
    }

    public static class RoundRobinScheduler
    {
        public static void Run()
        {
            var list = new CircularProcessList();
            Console.WriteLine("Enter processes as PID Burst Priority per line (blank to stop):");
            while(true){ var line=Console.ReadLine(); if(string.IsNullOrWhiteSpace(line)) break; var parts=line.Split(' ',StringSplitOptions.RemoveEmptyEntries); if(parts.Length<3) continue; list.AddAtEnd(new ProcessNode(parts[0], int.Parse(parts[1]), int.Parse(parts[2]))); }
            Console.Write("Time Quantum: "); var tq=int.TryParse(Console.ReadLine(), out var tv)?tv:2;
            // Simulate
            var executedOrder = new List<string>();
            var q = list.ToList();
            if(q.Count==0) { Console.WriteLine("No processes"); return; }
            var remaining = new Dictionary<string,int>(); foreach(var p in q) remaining[p.PID]=p.Burst;
            var time=0; var idx=0; while(remaining.Count>0)
            {
                var pid = q[idx].PID; var rem = remaining[pid]; var exec = Math.Min(tq, rem); remaining[pid] -= exec; time += exec; Console.WriteLine($"Running {pid} for {exec} (time={time})"); if(remaining[pid]==0){ Console.WriteLine($"{pid} finished"); remaining.Remove(pid); }
                idx = (idx+1) % q.Count; // skip finished processes while ensuring index validity
                while(remaining.Count>0 && !remaining.ContainsKey(q[idx].PID)) idx = (idx+1)%q.Count;
            }
            Console.WriteLine("All processes finished");
        }
    }
}
