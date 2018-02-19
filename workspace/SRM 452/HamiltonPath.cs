using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class HamiltonPath
{
    public int countPaths(string[] roads)
    {
        var n = roads.Length;
        var set = new DisjointSet(n);
        for (int i = 0; i < n; i++)
        {
            var cnt = 0;
            for (int j = 0; j < n; j++)
                if (roads[i][j] == 'Y') { cnt++; set.Unite(i, j); }
            if (cnt >= 3) return 0;
        }
        long ans = 1;
        var fact = 1;
        const long mod = 1000000007;
        for (int i = 0; i < n; i++)
            if (set[i] == i)
            {
                if (set.Edges(i) / 2 >= set.Size(i)) return 0;
                if (set.Size(i) > 1) ans = (ans * 2) % mod;
                ans = (ans * fact) % mod;
                fact++;
            }

        return (int)ans;
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
        test.ManualTest(new string[] {
"NNNYNNNYNNNNN",
"NNNNNNNNNNNNN",
"NNNNNNNNNNNNN",
"YNNNNNNNNNNYN",
"NNNNNYNYNNNNN",
"NNNNYNNNNNNNY",
"NNNNNNNNNNNNN",
"YNNNYNNNNNNNN",
"NNNNNNNNNNNNN",
"NNNNNNNNNNNNN",
"NNNNNNNNNNNYY",
"NNNYNNNNNNYNN",
"NNNNNYNNNNYNN" });
    }
}
// CUT end
#region DisjointSet
public class DisjointSet
{
    public int[] par, ranks, count, edges;
    public DisjointSet(int n)
    {
        par = new int[n];
        count = new int[n];
        edges = new int[n];
        for (int i = 0; i < n; i++)
        {
            par[i] = i;
            count[i] = 1;
        }
        ranks = new int[n];
    }
    public int this[int id] { get { return (par[id] == id) ? id : this[par[id]]; } }
    public bool Unite(int x, int y)
    {
        x = this[x]; y = this[y];

        if (x == y) { edges[x]++; return false; }
        if (ranks[x] < ranks[y])
        {
            par[x] = y;
            count[y] += count[x];
            edges[y] += edges[x] + 1;
        }
        else
        {
            par[y] = x;
            count[x] += count[y];
            edges[x] += edges[y] + 1;
            if (ranks[x] == ranks[y])
                ranks[x]++;
        }
        return true;
    }
    public int Size(int x) { return count[this[x]]; }
    public int Edges(int x) { return edges[this[x]]; }
    public bool IsUnited(int x, int y) { return this[x] == this[y]; }

}
#endregion