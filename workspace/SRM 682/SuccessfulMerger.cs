using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class SuccessfulMerger
{
    public int minimumMergers(int[] road)
    {
        var n = road.Length;
        var G = Enumerate(n, x => new List<int>());
        for (int i = 0; i < n; i++)
        {
            G[i].Add(road[i]);
            G[road[i]].Add(i);
        }
        var cycle = new bool[n];
        {
            for (int i = 0; i < n; i++)
                cycle[i] = true;
            foreach (var x in Graph.TopologicalSort(G, null)) cycle[x] = false;
        }
        var size = cycle.Count(x => x);
        var leaves = G.Count(x => x.Count == 1);
        var ans = n - leaves - 1;
        var ok = false;
        for (int i = 0; i < n; i++)
        {
            if (!cycle[i]) continue;
            if (G[i].Count == 2) ok = true;
        }
        if (ok) ans--;
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
#region TopologicalSort
static partial class Graph
{
    static public int[] TopologicalSort(List<int>[] G, int[] count = null)
    {
        const int Capacity = 1;//—LŒü‚È‚ç‚Î0–³Œü‚È‚ç‚Î1
        var n = G.Length;
        if (count == null)
        {
            count = new int[n];
            foreach (var l in G)
                foreach (var x in l) count[x]++;
        }
        var ret = new List<int>();
        var q = new Queue<int>();
        for (int i = 0; i < n; i++)
            if (count[i] == Capacity) q.Enqueue(i);
        while (q.Any())
        {
            var p = q.Dequeue();
            ret.Add(p);
            foreach (var x in G[p])
                if (--count[x] == Capacity) q.Enqueue(x);
        }
        return ret.ToArray();
    }

}
#endregion