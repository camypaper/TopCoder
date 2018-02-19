using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class Sunnygraphs
{
    public long count(int[] a)
    {
        var n = a.Length;
        var s = new DisjointSet(n);
        for (int i = 0; i < n; i++)
            s.Unite(i, a[i]);

        var g = new bool[n, n];
        for (int i = 0; i < n; i++)
            g[i, i] = true;
        for (int i = 0; i < n; i++)
            g[i, a[i]] = true;
        for (int k = 0; k < n; k++)
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    g[i, j] |= g[i, k] & g[k, j];
        var b = new int[4];
        for (int i = 0; i < n; i++)
        {
            if (g[0, i] & g[1, i]) b[2]++;
            else if (g[0, i]) b[0]++;
            else if (g[1, i]) b[1]++;
            else b[3]++;
        }
        if (!s.IsUnited(0, 1))
        {
            return ((1L << b[0]) - 1) * ((1L << b[1]) - 1) * (1L << b[3]);
        }
        return (1L << n) - ((1L << b[0]) + (1L << b[1]) - 2) * (1L << (b[3]));
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
        var A = new int[] { 6, 11, 27, 33, 0, 13, 2, 22, 15, 11, 7, 19, 17, 23, 30, 8, 9, 22, 6, 16, 16, 30, 0, 20, 4, 8, 5, 12, 31, 26, 16, 12, 25, 15, 12 };
        test.ManualTest(A);
    }
}
// CUT end
#region DisjointSet
public class DisjointSet
{
    public int[] par, ranks, count;
    public DisjointSet(int n)
    {
        par = new int[n];
        count = new int[n];
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
        if (x == y) return false;
        if (ranks[x] < ranks[y])
        {
            par[x] = y;
            count[y] += count[x];
        }
        else
        {
            par[y] = x;
            count[x] += count[y];
            if (ranks[x] == ranks[y])
                ranks[x]++;
        }
        return true;
    }
    public int Size(int x) { return count[this[x]]; }
    public bool IsUnited(int x, int y) { return this[x] == this[y]; }

}
#endregion
