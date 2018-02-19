using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class GearsDiv1
{
    public int getmin(string color, string[] graph)
    {
        var n = color.Length;
        var c = new int[n];
        for (int i = 0; i < n; i++)
            if (color[i] == 'R') c[i] = 0;
            else if (color[i] == 'G') c[i] = 1;
            else c[i] = 2;
        var min = 1000000000;
        for (int _ = 0; _ < 1 << 3; _++)
        {

            var s = new List<int>();
            for (int j = 0; j < 3; j++)
                if ((_ >> j & 1) == 1) s.Add(j);
            if (s.Count != 2) continue;
            var G = Enumerate(500, x => new List<Edge<int>>());
            for (int i = 0; i < n; i++)
            {
                if (c[i] == s[0])
                {
                    G.AddDirectedEdge(0, 100 + i, 1);
                }
                else if (c[i] == s[1])
                {
                    G.AddDirectedEdge(200 + i, 300, 1);
                }
            }
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (c[i] != s[0]) continue;
                    if (c[j] != s[1]) continue;
                    if (graph[i][j] != 'Y') continue;
                    G.AddDirectedEdge(100 + i, 200 + j, 1);
                }

            min = Math.Min(min, Flow.GetMaxFlow(G, 0, 300));
        }
        return min;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
// CUT begin
public class Tester : AbstractTester
{
    public override void Test()
    {
        //test.ManualTest();
        base.Test();
    }
}
// CUT end
#region Edge
public class Edge<T>
{
    public int to, rev;
    public T cap;
    public Edge(int t, int r, T _cap) { to = t; rev = r; cap = _cap; }
    public override string ToString() { return string.Format("{0}: Capacity {1}", to, cap); }
}
#endregion
#region AddEdge
static public partial class Flow
{
    static public void AddDirectedEdge(this List<Edge<int>>[] G, int from, int to, int cap)
    {
        G[from].Add(new Edge<int>(to, G[to].Count, cap));
        G[to].Add(new Edge<int>(from, G[from].Count - 1, 0));
    }
    static public void AddUndirectedEdge(this List<Edge<int>>[] G, int from, int to, int cap)
    {
        G[from].Add(new Edge<int>(to, G[to].Count, cap));
        G[to].Add(new Edge<int>(from, G[from].Count - 1, cap));
    }
    static public void AddDirectedEdge(this List<Edge<long>>[] G, int from, int to, long cap)
    {
        G[from].Add(new Edge<long>(to, G[to].Count, cap));
        G[to].Add(new Edge<long>(from, G[from].Count - 1, 0));
    }
    static public void AddUndirectedEdge(this List<Edge<long>>[] G, int from, int to, long cap)
    {
        G[from].Add(new Edge<long>(to, G[to].Count, cap));
        G[to].Add(new Edge<long>(from, G[from].Count - 1, cap));
    }
}
#endregion
#region In-Out
static public partial class Flow
{
    static public int GetIn(int id, int size) { return id; }
    static public int GetOut(int id, int size) { return id + size; }
}
#endregion


//MaxFlow   
#region Dinic
static public partial class Flow
{
    static public int GetMaxFlow(List<Edge<int>>[] G, int s, int t, int INF = 1 << 30)
    {
        var n = G.Length;
        var level = new int[n];
        var iter = new int[n];


        Action<int> bfs = p =>
        {
            for (int i = 0; i < n; i++)
                level[i] = -1;
            var q = new Queue<int>();
            level[s] = 0;
            q.Enqueue(s);
            while (q.Any())
            {
                var v = q.Dequeue();
                foreach (var e in G[v])
                    if (e.cap > 0 && level[e.to] < 0)
                    {
                        level[e.to] = level[v] + 1;
                        q.Enqueue(e.to);
                    }
            }
        };


        Func<int, int, int, int> dfs = null;
        dfs = (v, u, f) =>
        {
            if (v == t) return f;
            for (; iter[v] < G[v].Count; iter[v]++)
            {
                var e = G[v][iter[v]];
                if (e.cap <= 0 || level[v] >= level[e.to]) continue;
                var d = dfs(e.to, u, Math.Min(f, e.cap));
                if (d <= 0) continue;
                e.cap -= d;
                G[e.to][e.rev].cap += d;
                return d;
            }
            return 0;
        };


        var flow = 0;
        while (true)
        {
            bfs(s);
            if (level[t] < 0) return flow;
            Array.Clear(iter, 0, iter.Length);
            int f;
            while ((f = dfs(s, t, INF)) > 0) flow += f;
        }
    }
}
#endregion