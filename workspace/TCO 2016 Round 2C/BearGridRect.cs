using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BearGridRect
{
    public int[] findPermutation(int N, int[] r1, int[] r2, int[] c1, int[] c2, int[] cnt)
    {
        var m = r1.Length;
        var size = N + (m + 1);
        var G = Enumerate(2 * size + 2, x => new List<Edge<int, int>>());
        var src = 2 * size;
        var sink = 2 * size + 1;

        var id = new int[N, N];
        for (int i = 0; i < N; i++)
            for (int j = 0; j < N; j++)
                id[i, j] = m;
        for (int i = 0; i < m; i++)
        {
            for (int r = r1[i]; r <= r2[i]; r++)
                for (int c = c1[i]; c <= c2[i]; c++)
                    id[r, c] = i;
            for (int r = r1[i]; r <= r2[i]; r++)
                G.AddDirectedEdge(r, N + i, 1, 0);
            for (int c = c1[i]; c <= c2[i]; c++)
                G.AddDirectedEdge(size + N + i, size + c, 1, 0);
            G.AddDirectedEdge(N + i, size + N + i, cnt[i], 0);
        }
        //if (N - cnt.Sum() > 0) G.AddDirectedEdge(N + m, size + N + m, N - cnt.Sum());
        for (int i = 0; i < N; i++)
        {
            G.AddDirectedEdge(src, i, 1, 0);
            G.AddDirectedEdge(size + i, sink, 1, 0);

            for (int j = 0; j < N; j++)
            {
                if (id[i, j] == m)
                    G.AddDirectedEdge(i, size + j, 1, 100000);
            }
        }
        var f = Flow.GetMinCostFlow(G, src, sink, N, N, size);
        Debug.WriteLine(f);
        if (f != (N - cnt.Sum()) * 100000) return new int[] { -1 };
        var ans = new int[N];
        for (int i = 0; i < m; i++)
        {
            var from = new List<int>();
            var to = new List<int>();
            foreach (var e in G[N + i])
            {
                if (0 <= e.to && e.to < N && e.cap == 1) from.Add(e.to);
            }
            foreach (var e in G[size + N + i])
            {
                if (size <= e.to && e.to < size + N && e.cap == 0) to.Add(e.to - size);
            }
            for (int j = 0; j < from.Count; j++)
                ans[from[j]] = to[j];
        }
        for (int i = 0; i < N; i++)
        {
            var to = new List<int>();
            foreach (var e in G[i])
            {
                if (size <= e.to && e.to < size + N && e.cap == 0) to.Add(e.to - size);
            }
            if (to.Count > 0)
                ans[i] = to[0];
        }
        return ans;
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
#region CostEdge
static public class Edge
{
    static public Edge<C, V> Create<C, V>(int t, int r, C _cap, V _cost) { return new Edge<C, V>(t, r, _cap, _cost); }
}
public class Edge<C, V>
{
    public int to, rev;
    public C cap;
    public V cost;
    public Edge(int t, int r, C _cap, V _cost) { to = t; rev = r; cap = _cap; cost = _cost; }
    public override string ToString() { return string.Format("{0}: Capacity {1}, Cost{2}", to, cap, cost); }
}
#endregion

#region AddCostEdge
static public partial class Flow
{
    static public void AddDirectedEdge(this List<Edge<int, int>>[] G, int from, int to, int cap, int cost)
    {
        G[from].Add(Edge.Create(to, G[to].Count, cap, cost));
        G[to].Add(Edge.Create(from, G[from].Count - 1, 0, -cost));
    }
    static public void AddDirectedEdge(this List<Edge<int, double>>[] G, int from, int to, int cap, double cost)
    {
        G[from].Add(Edge.Create(to, G[to].Count, cap, cost));
        G[to].Add(Edge.Create(from, G[from].Count - 1, 0, -cost));
    }

}
#endregion

#region Integer MinCostFlow
static public partial class Flow
{
    static public int GetMinCostFlow(List<Edge<int, int>>[] G, int s, int t, int f, int N, int Size, int INF = 1 << 30)
    {
        var usdF = new bool[N];
        var usdT = new bool[N];
        var res = 0;
        var n = G.Length;
        var dist = new int[n];
        var prevV = new int[n];
        var prevE = new int[n];
        while (f > 0)
        {
            for (int i = 0; i < n; i++)
                dist[i] = INF;
            dist[s] = 0;
            var update = true;
            while (update)
            {
                update = false;
                for (int v = 0; v < n; v++)
                {
                    if (dist[v] == INF) continue;
                    for (int i = 0; i < G[v].Count; i++)
                    {
                        var e = G[v][i];
                        if (e.cap <= 0 || dist[e.to] <= dist[v] + e.cost)
                            continue;
                        dist[e.to] = dist[v] + e.cost;
                        prevV[e.to] = v;
                        prevE[e.to] = i;
                        update = true;

                    }
                }
            }
            if (dist[t] == INF)
                return -1;
            var d = f;
            for (int v = t; v != s; v = prevV[v])
                d = Math.Min(d, G[prevV[v]][prevE[v]].cap);
            f -= d;
            res += d * dist[t];

            for (int v = t; v != s; v = prevV[v])
            {
                Console.Write(string.Format("{0} ", v));
                var e = G[prevV[v]][prevE[v]];
                e.cap -= d;
                G[v][e.rev].cap += d;
            }
            Console.WriteLine();
        }
        return res;
    }
}
#endregion
