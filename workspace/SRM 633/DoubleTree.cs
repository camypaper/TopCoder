using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
using C = System.Int32;

public class DoubleTree
{
    public int maximalScore(int[] a, int[] b, int[] c, int[] d, int[] score)
    {
        var n = a.Length + 1;
        var max = 0;
        var G = Enumerate(2, y => Enumerate(n, x => new List<int>()));
        for (int i = 0; i < n - 1; i++)
        {
            G[0][a[i]].Add(b[i]);
            G[0][b[i]].Add(a[i]);
            G[1][c[i]].Add(d[i]);
            G[1][d[i]].Add(c[i]);
        }
        for (int r = 0; r < n; r++)
        {
            var p = Enumerate(2, x => new int[n]);
            for (int k = 0; k < 2; k++)
            {
                Func<int, int, int> dfs = null;
                dfs = (prev, cur) =>
                  {
                      p[k][cur] = prev;
                      foreach (var to in G[k][cur])
                          if (to != prev) dfs(cur, to);
                      return 0;
                  };
                dfs(-1, r);
            }
            var F = Enumerate(n * 2 + 2, x => new List<Edge>());
            var sum = score[r];
            var src = n * 2;
            var sink = n * 2 + 1;
            for (int i = 0; i < n; i++)
            {
                if (i == r) continue;
                if (score[i] > 0)
                {
                    sum += score[i];
                    F.AddDirectedEdge(src, i, 0);
                    //F.AddDirectedEdge(i, i + n, 1000000000);
                    F.AddDirectedEdge(i, sink, score[i]);
                }
                else
                {
                    F.AddDirectedEdge(src, i, -score[i]);
                    //F.AddDirectedEdge(i, i + n, 1000000000);
                    F.AddDirectedEdge(i, sink, 0);
                }
                if (p[0][i] != r)
                    F.AddDirectedEdge(p[0][i], i, 1000000000);
                if (p[1][i] != r)
                    F.AddDirectedEdge(p[1][i], i, 1000000000);
            }
            var cost = Flow.GetMaxFlow(F, src, sink);
            max = Math.Max(max, sum - cost);
        }
        return max;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int[] a, int[] b, int[] c, int[] d, int[] score)
    {
        return 0;
    }

    // CUT end
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
// CUT begin
public partial class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public override void Run()
    {
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);
        Test(Example5);

    }
}
// CUT end
#region Edge
public class Edge
{
    public int to, rev;
    public C cap;
    public Edge(int t, int r, C _cap) { to = t; rev = r; cap = _cap; }
    public override string ToString() { return string.Format("{0}: Capacity {1}", to, cap); }
}
#endregion
#region AddEdge
static public partial class Flow
{
    static public void AddDirectedEdge(this List<Edge>[] G, int from, int to, C cap)
    {
        G[from].Add(new Edge(to, G[to].Count, cap));
        G[to].Add(new Edge(from, G[from].Count - 1, 0));
    }
    static public void AddUndirectedEdge(this List<Edge>[] G, int from, int to, int cap)
    {
        G[from].Add(new Edge(to, G[to].Count, cap));
        G[to].Add(new Edge(from, G[from].Count - 1, cap));
    }
}
#endregion


//MaxFlow
#region Dinic
static public partial class Flow
{
    static public C GetMaxFlow(List<Edge>[] G, int s, int t, C INF = -1)
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
            while (q.Count > 0)
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


        Func<int, int, C, C> dfs = null;
        dfs = (v, u, f) =>
        {
            if (v == t) return f;
            var ret = 0;
            for (; iter[v] < G[v].Count; iter[v]++)
            {
                var e = G[v][iter[v]];
                if (e.cap <= 0 || level[v] >= level[e.to]) continue;
                var d = dfs(e.to, u, Math.Min(f, e.cap));
                if (d <= 0) continue;
                e.cap -= d;
                G[e.to][e.rev].cap += d;
                ret += d; f -= d;
                if (f == 0) break;
            }
            return ret;
        };


        C flow = 0;
        if (INF == -1) INF = C.MaxValue;
        while (INF > 0)
        {
            bfs(s);
            if (level[t] == 0) return flow;
            Array.Clear(iter, 0, iter.Length);
            C f;
            while ((f = dfs(s, t, INF)) > 0) { flow += f; }
        }
        return flow;

    }
}
#endregion