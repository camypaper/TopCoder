using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class TheKingsRoadsDiv1
{
    public string getAnswer(int h, int[] a, int[] b)
    {
        var n = (1 << h) - 1;
        var G = Enumerate(n, x => new List<int>());
        var s = new DisjointSet(n);
        for (int i = 0; i < a.Length; i++)
        {
            a[i]--; b[i]--;
            if (a[i] > b[i]) Swap(ref a[i], ref b[i]);
            var ok = true;
            for (int j = i - 1; j >= 0; j--)
                if (a[i] == a[j] && b[i] == b[j]) ok = false;
            if (!ok) continue;
            if (a[i] != b[i])
            {
                G[a[i]].Add(from.Count);
                G[b[i]].Add(from.Count);

                from.Add(a[i]);
                to.Add(b[i]);
            }
            s.Unite(a[i], b[i]);
        }
        if (s.Size(0) == n && f(G, n, h)) return "Correct";
        else return "Incorrect";
    }
    List<int> from = new List<int>(), to = new List<int>();
    public bool f(List<int>[] G, int n, int H)
    {
        var d = new int[n];
        for (int i = 0; i < n; i++)
            d[i] = G[i].Count;
        var dc = new int[7];
        for (int i = 0; i < n; i++)
        {
            if (d[i] > 6) return false;
            dc[d[i]]++;
        }

        var R = 1;
        var L = 1 << (H - 1);
        var SR = n - R - L;
        var m = from.Count;
        if (m == n - 1) return dc[1] == L && dc[2] == 1 && dc[3] == SR;
        var usedE = new bool[m];

        for (int i = 0; i < m; i++)
        {
            dc[d[from[i]]]--;
            dc[d[to[i]]]--;
            d[from[i]]--;
            d[to[i]]--;
            dc[d[from[i]]]++;
            dc[d[to[i]]]++;
            usedE[i] = true;
            for (int j = i + 1; j < m; j++)
            {
                dc[d[from[j]]]--;
                dc[d[to[j]]]--;
                d[from[j]]--;
                d[to[j]]--;
                dc[d[from[j]]]++;
                dc[d[to[j]]]++;
                usedE[j] = true;
                var ok = true;
                if (dc[5] + dc[6] > 0) ok = false;
                if (dc[4] > 2) ok = false;
                if (dc[3] + dc[4] < SR) ok = false;
                if (dc[0] > 0) ok = false;
                if (dc[1] > L) ok = false;
                if (ok)
                {
                    for (int k = j + 1; k < m; k++)
                    {
                        dc[d[from[k]]]--;
                        dc[d[to[k]]]--;
                        d[from[k]]--;
                        d[to[k]]--;
                        dc[d[from[k]]]++;
                        dc[d[to[k]]]++;
                        usedE[k] = true;
                        {
                            var root = -1;
                            for (int t = 0; t < n; t++)
                                if (d[t] == 2) root = t;
                            if (m == n + 2 && dc[1] == L && dc[2] == 1 && dc[3] == SR && count(G, root, H, usedE) == (1 << H) - 1)
                                return true;
                        }
                        dc[d[from[k]]]--;
                        dc[d[to[k]]]--;
                        d[from[k]]++;
                        d[to[k]]++;
                        dc[d[from[k]]]++;
                        dc[d[to[k]]]++;
                        usedE[k] = false;
                    }
                }
                {
                    var root = -1;
                    for (int t = 0; t < n; t++)
                        if (d[t] == 2) root = t;
                    if (m == n + 1 && dc[1] == L && dc[2] == 1 && dc[3] == SR && count(G, root, H, usedE) == (1 << H) - 1)
                        return true;
                }
                dc[d[from[j]]]--;
                dc[d[to[j]]]--;
                d[from[j]]++;
                d[to[j]]++;
                dc[d[from[j]]]++;
                dc[d[to[j]]]++;
                usedE[j] = false;
            }
            {
                var root = -1;
                for (int t = 0; t < n; t++)
                    if (d[t] == 2) root = t;
                if (m == n && dc[1] == L && dc[2] == 1 && dc[3] == SR && count(G, root, H, usedE) == (1 << H) - 1)
                    return true;
            }
            dc[d[from[i]]]--;
            dc[d[to[i]]]--;
            d[from[i]]++;
            d[to[i]]++;
            dc[d[from[i]]]++;
            dc[d[to[i]]]++;
            usedE[i] = false;
        }
        return false;
    }
    int count(List<int>[] G, int r, int h, bool[] usedE)
    {
        Debug.WriteLine("{0} {1}", r, h);
        if (h < 0) return -1000;
        var cnt = 1;
        foreach (var id in G[r])
        {
            if (usedE[id]) continue;
            usedE[id] = true;
            var t = from[id] != r ? from[id] : to[id];
            cnt += count(G, t, h - 1, usedE);
            usedE[id] = false;
        }
        if (cnt != (1 << h) - 1) return -1000;
        return cnt;
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
        test.ManualTest(3, new int[] { 6, 3, 2, 3, 7, 4, 4, 1, 2 }, new int[] { 7, 1, 5, 6, 1, 2, 3, 6, 7 });
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