using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class AllGraphCuts
{
    public int[] findGraph(int[] a)
    {
        var n = 1;
        while (n * n < a.Length) n++;
        var E = Enumerate(100050, x => new List<KeyValuePair<int, int>>());
        for (int i = 0; i < n; i++)
            for (int j = i; j < n; j++)
            {
                var f = a[i * n + j];
                var t = a[j * n + i];
                if (f != t) return new int[] { -1 };
                if (i == j && f != 0) return new int[] { -1 };
                E[a[i * n + j]].Add(new KeyValuePair<int, int>(i, j));
            }
        var s = new DisjointSet(n);
        var ans = new List<int>();
        for (int i = 100049; i >= 0; i--)
        {
            var go = new List<KeyValuePair<int, int>>();
            foreach (var kv in E[i])
            {
                if (kv.Key != kv.Value && s.IsUnited(kv.Key, kv.Value))
                    return new int[] { -1 };
                go.Add(kv);
            }
            foreach (var kv in go)
            {
                if (s.IsUnited(kv.Key, kv.Value)) continue;
                s.Unite(kv.Key, kv.Value);
                ans.Add(i * n * n + kv.Key * n + kv.Value);
            }
        }
        if (s.Size(0) != n) return new int[] { -1 };
        return ans.ToArray();
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
        //var a = new int[] { 0, 2545, 2348, 2993, 2606, 2623, 2013, 3001, 2626, 2440, 2495, 2262, 2342, 2617, 2773, 2662, 2736, 2827, 3044, 3082, 2545, 0, 2348, 2545, 2545, 2545, 2013, 2545, 2545, 2440, 2495, 2262, 2342, 2545, 2545, 2545, 2545, 2545, 2545, 2545, 2348, 2348, 0, 2348, 2348, 2348, 2013, 2348, 2348, 2348, 2348, 2262, 2342, 2348, 2348, 2348, 2348, 2348, 2348, 2348, 2993, 2545, 2348, 0, 2606, 2623, 2013, 2993, 2626, 2440, 2495, 2262, 2342, 2617, 2773, 2662, 2736, 2827, 2993, 2993, 2606, 2545, 2348, 2606, 0, 2606, 2013, 2606, 2606, 2440, 2495, 2262, 2342, 2606, 2606, 2606, 2606, 2606, 2606, 2606, 2623, 2545, 2348, 2623, 2606, 0, 2013, 2623, 2623, 2440, 2495, 2262, 2342, 2617, 2623, 2623, 2623, 2623, 2623, 2623, 2013, 2013, 2013, 2013, 2013, 2013, 0, 2013, 2013, 2013, 2013, 2013, 2013, 2013, 2013, 2013, 2013, 2013, 2013, 2013, 3001, 2545, 2348, 2993, 2606, 2623, 2013, 0, 2626, 2440, 2495, 2262, 2342, 2617, 2773, 2662, 2736, 2827, 3001, 3001, 2626, 2545, 2348, 2626, 2606, 2623, 2013, 2626, 0, 2440, 2495, 2262, 2342, 2617, 2626, 2626, 2626, 2626, 2626, 2626, 2440, 2440, 2348, 2440, 2440, 2440, 2013, 2440, 2440, 0, 2440, 2262, 2342, 2440, 2440, 2440, 2440, 2440, 2440, 2440, 2495, 2495, 2348, 2495, 2495, 2495, 2013, 2495, 2495, 2440, 0, 2262, 2342, 2495, 2495, 2495, 2495, 2495, 2495, 2495, 2262, 2262, 2262, 2262, 2262, 2262, 2013, 2262, 2262, 2262, 2262, 0, 2262, 2262, 2262, 2262, 2262, 2262, 2262, 2262, 2342, 2342, 2342, 2342, 2342, 2342, 2013, 2342, 2342, 2342, 2342, 2262, 0, 2342, 2342, 2342, 2342, 2342, 2342, 2342, 2617, 2545, 2348, 2617, 2606, 2617, 2013, 2617, 2617, 2440, 2495, 2262, 2342, 0, 2617, 2617, 2617, 2617, 2617, 2617, 2773, 2545, 2348, 2773, 2606, 2623, 2013, 2773, 2626, 2440, 2495, 2262, 2342, 2617, 0, 2662, 2736, 2773, 2773, 2773, 2662, 2545, 2348, 2662, 2606, 2623, 2013, 2662, 2626, 2440, 2495, 2262, 2342, 2617, 2662, 0, 2662, 2662, 2662, 2662, 2736, 2545, 2348, 2736, 2606, 2623, 2013, 2736, 2626, 2440, 2495, 2262, 2342, 2617, 2736, 2662, 0, 2736, 2736, 2736, 2827, 2545, 2348, 2827, 2606, 2623, 2013, 2827, 2626, 2440, 2495, 2262, 2342, 2617, 2773, 2662, 2736, 0, 2827, 2827, 3044, 2545, 2348, 2993, 2606, 2623, 2013, 3001, 2626, 2440, 2495, 2262, 2342, 2617, 2773, 2662, 2736, 2827, 0, 3044, 3082, 2545, 2348, 2993, 2606, 2623, 2013, 3001, 2626, 2440, 2495, 2262, 2342, 2617, 2773, 2662, 2736, 2827, 3044, 0 };
        var a = new int[] { 0, 2, 2, 2, 0, 2, 2, 2, 0 };
        test.ManualTest(a);

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