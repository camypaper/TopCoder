using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class Singing
{
    public int solve(int N, int low, int high, int[] pitch)
    {
        var G = Enumerate(N + 2, x => new List<Edge<int>>());
        var s = N;
        var t = N + 1;
        const int X = 10000000;
        for (int i = 1; i <= N; i++)
        {
            if (low <= i) G.AddDirectedEdge(s, i - 1, 0);
            else G.AddDirectedEdge(s, i - 1, X);
            if (i <= high) G.AddDirectedEdge(i - 1, t, 0);
            else G.AddDirectedEdge(i - 1, t, X);
        }

        var cost = new int[N + 2, N + 2];
        for (int i = 0; i < pitch.Length; i++)
        {
            if (i > 0) { cost[pitch[i], pitch[i - 1]]++; cost[pitch[i - 1], pitch[i]]++; }
        }
        for (int i = 1; i <= N; i++)
            for (int j = 1; j < i; j++)
                G.AddUndirectedEdge(i - 1, j - 1, cost[i, j]);

        var cut = Flow.GetMaxFlow(G, s, t);
        return cut;
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
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
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


//MaxFlow
#region Dinic
static public partial class Flow
{
    static public int GetMaxFlow(List<Edge<int>>[] G, int s, int t, int INF = -1)
    {
        var n = G.Length;
        var level = new int[n];
        var iter = new int[n];


        Action<int> bfs = p =>
        {
            Array.Clear(level, 0, n);
            var q = new Queue<int>();
            level[s] = 1;
            q.Enqueue(s);
            while (q.Any())
            {
                var v = q.Dequeue();
                foreach (var e in G[v])
                    if (e.cap > 0 && level[e.to] == 0)
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
        if (INF == -1)
        {
            while (true)
            {
                bfs(s);
                if (level[t] == 0) return flow;
                Array.Clear(iter, 0, iter.Length);
                int f;
                while ((f = dfs(s, t, 1 << 30)) > 0) { flow += f; }
            }
        }
        else
        {
            while (INF > 0)
            {
                bfs(s);
                if (level[t] == 0) return flow;
                Array.Clear(iter, 0, iter.Length);
                int f;
                while ((f = dfs(s, t, 1 << 30)) > 0) { flow += f; INF -= f; }
            }
            return flow;
        }
    }
}
#endregion