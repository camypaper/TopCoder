using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class SegmentsAndPoints
{
    public string isPossible(int[] p, int[] l, int[] r)
    {
        var n = p.Length;
        var G = Enumerate(n * 2, x => new List<int>());
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if(l[j]<=p[i]&&p[i]<=r[j])
                {
                    G[i].Add(n + j);
                    G[n + j].Add(i);
                }
            }
        }
        var match = Graph.BipartiteMatching(G);
        if (match == n) return "Possible";
        return "Impossible";
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
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
#region BipartiteMatching with Adjacency List
static partial class Graph
{
    static public int BipartiteMatching(List<int>[] G)
    {
        var n = G.Length;
        var match = new int[n];
        var used = new bool[n];
        var res = 0;
        for (int i = 0; i < n; i++)
            match[i] = -1;
        Func<int, bool> dfs = null;
        dfs = v =>
        {
            used[v] = true;
            foreach (var u in G[v])
            {
                var w = match[u];
                if (w < 0 || !used[w] && dfs(w))
                {
                    match[v] = u;
                    match[u] = v;
                    return true;
                }
            }
            return false;
        };
        for (int v = 0; v < n; v++)
        {
            if (match[v] >= 0) continue;
            Array.Clear(used, 0, n);
            if (dfs(v)) res++;
        }
        return res;

    }
}
#endregion